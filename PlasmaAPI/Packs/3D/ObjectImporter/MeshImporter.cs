extern alias PLibrary;
extern alias GameClass;

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.IO.Compression;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using Assimp;
using Plasma.Application.Extensions;
using Plasma.Packs.MeshUtil;
using UnityEngine;
using Material = UnityEngine.Material;
using Mesh = UnityEngine.Mesh;
using Plasma.Application.InternalClass;
using System.Xml.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Plasma.Packs.MeshUtil.Internal;
using Plasma.API.Classes;
using System.Collections;

using Color = UnityEngine.Color;
using System.Windows.Media.Media3D;
using Assimp.Unmanaged;
using StbImageSharp;
using static GameClass::LuaTableContent;
using MonoMod.Utils;
using ImageProcessor.Processors;

namespace Plasma.Packs
{
    public class MeshImporter
    {
        private static readonly ConcurrentDictionary<string, (GameObject, IEnumerable<GameObject>)> SavedMeshData = new ConcurrentDictionary<string, (GameObject, IEnumerable<GameObject>)>();
        internal static (bool, ResourceStream) GetFileStream(string Texture, Dictionary<string, ResourceStream> FileStreams)
        {
            if (FileStreams == null || Texture == null)
                return (false, null);

            string[] Keys = FileStreams.Keys.Select(k => k.ToLowerInvariant()).ToArray();
            Dictionary<string, string> KeyMap = new Dictionary<string, string>();

            foreach(var kvp in FileStreams.Keys.Select(k => new KeyValuePair<string, string>(k.ToLowerInvariant(), k)))
                if (!KeyMap.ContainsKey(kvp.Key))
                    KeyMap.Add(kvp.Key, kvp.Value);

            string[] Names = new string[]
            {
                Texture.ToLowerInvariant(),
                Path.GetFileName(Texture).ToLowerInvariant(),
                Path.GetFileNameWithoutExtension(Texture).ToLowerInvariant()
            };

            string TextureName = Names.Where(x => Keys.Contains(x)).FirstOrDefault();

            if (TextureName == default)
                return (false, null);

            TextureName = KeyMap[TextureName];

            if (FileStreams.TryGetValue(TextureName, out ResourceStream TextureStream))
            {
                TextureStream.Position = 0;
                return (true, TextureStream);
            }

            return (false, null);
        }
        internal static (bool, ResourceStream) GetFileStream(string Texture, IEnumerable<(string Key, ResourceStream Value)> FileStreams)
        {
            Dictionary<string, ResourceStream> tmp = new Dictionary<string, ResourceStream>();
            foreach (var (Key, Value) in FileStreams)
                tmp.Add(Key, Value);
            return GetFileStream(Texture, tmp);
        }

        public static byte[] FindTexture(string Texture, Dictionary<string, ResourceStream> Textures)
        {
            var (wasFound, TextureStream) = GetFileStream(Texture, Textures);

            if (wasFound)
            {
                int length = (int)TextureStream.Length;
                TextureStream.Position = 0;
                using var reader = new BinaryReader(TextureStream);
                return reader.ReadBytes(length);
            }

            return null;
        }

        public static ResourceStream FindTextureStream(string Texture, Dictionary<string, ResourceStream> Textures)
        {
            var (wasFound, TextureStream) = GetFileStream(Texture, Textures);

            if (wasFound)
            {
                return TextureStream;
            }

            return null;
        }

        public static byte[] FindTexture(string Texture, IEnumerable<(string, ResourceStream)> Textures)
        {
            var (wasFound, TextureStream) = GetFileStream(Texture, Textures);

            if (wasFound)
            {
                int length = (int)TextureStream.Length;
                using var reader = new BinaryReader(TextureStream);
                return reader.ReadBytes(length);
            }

            return null;
        }

        public static GameObject Load(AbstractGestalt Gestalt, GameObject root)
        {
            var Mesh = Gestalt.MeshResources.First();
            (Dictionary<string, ResourceStream> Textures, (string Name, ResourceStream Data) File) = (Gestalt.TextureResources, Gestalt.MeshResources.LastOrDefault());

            AssimpContext importer = new AssimpContext();
            List<GameObject> ColliderHolder = new List<GameObject>();
            GenericModelIO io;
            GameObject ret = null;
            Scene scene = null;

            PostProcessSteps postProcess = PostProcessSteps.Triangulate |
                                PostProcessSteps.JoinIdenticalVertices |
                                PostProcessSteps.SortByPrimitiveType |
                                PostProcessSteps.GenerateSmoothNormals;

            Mesh.Data.Position = 0;
            var hash = string.Join("", new Crc32().ComputeHash(Mesh.Data).Select(h => h.ToString("X")));

            if (MeshImporter.SavedMeshData.TryGetValue(hash, out (GameObject r, IEnumerable<GameObject> c)d))
            {
                ColliderHolder.AddRange(d.c);
                ret = GameObject.Instantiate(d.r);
                ret.SetActive(true);
                ret.name = ret.name.Replace("(Clone)", "");
                goto finish;
            }
            else
            {
                if (ModelUtil.Detect(File.Data) == MeshType.OBJ)
                    io = new WavefrontIO(Mesh, Textures);
                else
                    io = new GenericModelIO(Mesh, Textures);

                importer.SetIOSystem(io);

                scene = importer.ImportFile(io.GetMeshName(), postProcess);
            }

            
            if (scene == null)
                return null;

            var WashColor = new Color4D(1,1,1,1);

            if (Gestalt.CustomTextureData.HasValue)
            {
                var tex_data = Gestalt.CustomTextureData.Value;
                var mlist = scene.Materials.Where(m => m.Name.Equals(tex_data.MaterialName)).ToArray();
                
                if (mlist.LongLength > 0)
                {
                    var mat = mlist[0];
                    mat.TextureDiffuse = tex_data.Diffuse;
                    mat.TextureNormal = tex_data.Normal;
                    mat.TextureSpecular = tex_data.Specular;
                }

                WashColor = new Color4D(
                    tex_data.BaseColor.r,
                    tex_data.BaseColor.g,
                    tex_data.BaseColor.b,
                    tex_data.BaseColor.a);
            }

            /*
            if (!File.Exists(hash + ".json"))
                File.WriteAllText(hash + ".json",
                    JsonConvert.SerializeObject(scene, Formatting.Indented,
                    new JsonSerializerSettings()
                    {
                        DefaultValueHandling = DefaultValueHandling.Ignore,
                        NullValueHandling = NullValueHandling.Ignore,
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    }));
            */

            // Materials
            List<UnityEngine.Material> uMaterials = new List<UnityEngine.Material>();
            if (scene.HasMaterials)
            {
                foreach (var m in scene.Materials)
                {
                    UnityEngine.Material uMaterial = new UnityEngine.Material(UnityEngine.Shader.Find("Plasma/Component Standard v1.3 No Tess"));

                    // Albedo
                    if (m.HasColorDiffuse)
                    {
                        // Debug.LogWarning("lkjdhnaskljdhlkasjdasjd;asjd;jas;djaslkdjaslkjflk");
                        Color color = new Color(
                            m.ColorDiffuse.R,
                            m.ColorDiffuse.G,
                            m.ColorDiffuse.B,
                            m.ColorDiffuse.A
                        );
                        // uMaterial.color = color;
                        uMaterial.SetColor("_BaseColor", color);
                    }

                    // Ambient
                    if (m.HasColorAmbient)
                    {
                        /*
                        Color color = new Color(
                            m.ColorAmbient.R,
                            m.ColorAmbient.G,
                            m.ColorAmbient.B,
                            m.ColorAmbient.A
                        );
                        // uMaterial.color = color;
                        uMaterial.SetColor("_BaseColor", color);
                        */
                    }

                    // Emission
                    if (m.HasColorEmissive)
                    {
                        Color color = new Color(
                            m.ColorEmissive.R,
                            m.ColorEmissive.G,
                            m.ColorEmissive.B,
                            m.ColorEmissive.A
                        );
                        uMaterial.SetColor("_EmColor0", color);
                        // uMaterial.EnableKeyword("_EMISSION");
                    }
                    
                    // Reflectivity
                    if (m.HasReflectivity)
                    {
                        uMaterial.SetFloat("_Glossiness", m.Reflectivity);
                    }

                    
                    // Normal
                    /*
                    if (m.HasTextureNormal)
                    {
                        Texture2D uTexture = new Texture2D(2, 2);

                        byte[] byteArray = MeshImporter.FindTexture(m.TextureNormal.FilePath, Textures);
                        bool isLoaded = uTexture.LoadImage(byteArray);
                        if (!isLoaded)
                        {
                            Debug.LogWarning("Failed to load texture file: " + m.TextureNormal.FilePath);
                            //throw new Exception("Cannot find texture file: " + m.TextureNormal.FilePath);
                        }
                        else
                        {
                            uMaterial.SetTexture("_DetailNmlTex", uTexture);
                        }
                    }*/
                    /*
                    // Height
                    if (m.HasTextureHeight)
                    {
                        Texture2D uTexture = new Texture2D(2, 2);

                        byte[] byteArray = MeshImporter.FindTexture(m.TextureHeight.FilePath, TextureData.Textures);
                        bool isLoaded = uTexture.LoadImage(byteArray);
                        if (!isLoaded)
                        {
                            throw new Exception("Cannot find texture file: " + m.TextureHeight.FilePath);
                        }

                        uMaterial.SetTexture("_DetailMaskTex", uTexture);
                    }

                    // Bump
                    if (m.HasBumpScaling)
                    {
                        uMaterial.SetFloat("_CSDetailNormalFactor", m.BumpScaling);
                    }

                    // Metal?
                    if (m.HasShininess)
                    {
                        uMaterial.SetFloat("_CSMetallic", m.Shininess * m.ShininessStrength);
                    }
                    */

                    // m.colo

                    // Texture
                    if (m.HasTextureDiffuse)
                    {
                        ResourceStream texStream = MeshImporter.FindTextureStream(m.TextureDiffuse.FilePath, Textures);
                        texStream ??= Textures.Values.Count > 0 ? Textures.Values.ToArray()[m.TextureDiffuse.TextureIndex] : null;
                        if (texStream != null)
                        {
                            ResourceStream alpha = null;
                            // Normal
                            if (m.HasTextureNormal)
                            {
                                alpha = MeshImporter.FindTextureStream(m.TextureNormal.FilePath, Textures);
                                /*
                                bool isLoaded = uTexture.LoadImage(byteArray);
                                if (!isLoaded)
                                {
                                    Debug.LogWarning("Failed to load texture file: " + m.TextureNormal.FilePath);
                                    //throw new Exception("Cannot find texture file: " + m.TextureNormal.FilePath);
                                }
                                else
                                {
                                    uMaterial.SetTexture("_DetailNmlTex", uTexture);
                                }*/
                            }
                            Texture2D uTexture = MeshImporter.LoadTexture(texStream, WashColor, alpha) ?? throw new Exception("Cannot find texture file: " + m.TextureDiffuse.FilePath);
                            uMaterial.SetTexture("_DetailAlbTex", uTexture);
                        }
                    }
                    else if (m.HasColorDiffuse)
                    {
                        int width = 1, height = 1;
                        Texture2D texture = new Texture2D(width, height, TextureFormat.RGBA32, false);

                        Color c = new Color(
                                    m.ColorDiffuse.R,
                                    m.ColorDiffuse.G,
                                    m.ColorDiffuse.B,
                                    m.ColorDiffuse.A);

                        /*
                        // Set all pixels to the specified color
                        for (int y = 0; y < height; y++)
                        {
                            for (int x = 0; x < width; x++)
                            {
                                
                            }
                        }
                        */

                        texture.SetPixel(0, 0, c);

                        // Apply the changes to the texture and return it
                        texture.Apply();
                        uMaterial.SetTexture("_DetailAlbTex", texture);
                    }

                    uMaterials.Add(uMaterial);
                }
            }

            // Mesh
            List<MeshMaterialBinding> uMeshAndMats = new List<MeshMaterialBinding>();
            if (scene.HasMeshes)
            {
                foreach (var m in scene.Meshes)
                {
                    List<Vector3> uVertices = new List<Vector3>();
                    List<Vector3> uNormals = new List<Vector3>();
                    List<Vector2> uUv = new List<Vector2>();
                    List<Vector4> tan = new List<Vector4>();
                    List<int> uIndices = new List<int>();
                
                    // Vertices
                    if (m.HasVertices)
                    {
                        foreach (var v in m.Vertices)
                        {
                            uVertices.Add(new Vector3(-v.X, v.Y, v.Z));
                        }
                    }

                    // Normals
                    if (m.HasNormals)
                    {
                        foreach (var n in m.Normals)
                        {
                            uNormals.Add(new Vector3(-n.X, n.Y, n.Z));
                        }
                    }

                    // Triangles
                    if (m.HasFaces)
                    {
                        foreach (var f in m.Faces)
                        {
                            // Ignore degenerate faces
                            if (f.IndexCount == 1 || f.IndexCount == 2)
                                continue;

                            for(int i=0;i<(f.IndexCount-2);i++)
                            {
                                uIndices.Add(f.Indices[i+2]);
                                uIndices.Add(f.Indices[i+1]);
                                uIndices.Add(f.Indices[0]);
                            }
                        }
                    }
                    /*
                    if (m.HasTangentBasis)
                    {
                        tan = m.Tangents.Select(t => new Vector4(t.X, t.Y, t.Z, t.W)).ToArray();
                    }*/

                    // Uv (texture coordinate) 
                    if (m.HasTextureCoords(0))
                    {
                        foreach (var uv in m.TextureCoordinateChannels[0])
                        {
                            uUv.Add(new Vector2(uv.X, uv.Y));
                        }
                    }

                    UnityEngine.Mesh uMesh = new UnityEngine.Mesh
                    {
                        vertices = uVertices.ToArray(),
                        normals = uNormals.ToArray(),
                        triangles = uIndices.ToArray(),
                        uv = uUv.ToArray(),
                        tangents = tan.ToArray()
                    };

                    uMeshAndMats.Add(new MeshMaterialBinding(m.Name, uMesh, uMaterials[m.MaterialIndex]));
                }
            }

            // Create GameObjects from nodes
            List<GameObject> NodeToGameObject(Node node, bool isRoot = true)
            {
                List<GameObject> Lret = new List<GameObject> ();
                if (isRoot)
                {
                    Lret.Add(new GameObject() { name = "MeshHolder" });
                }
                // Set Mesh
                if (node.HasMeshes)
                {
                    foreach (var mIdx in node.MeshIndices)
                    {
                        var uMeshAndMat = uMeshAndMats[mIdx];

                        GameObject uOb = new GameObject(node.Name);
                        GameObject.DontDestroyOnLoad(uOb);

                        var mfilter = uOb.AddComponent<MeshFilter>();
                        var mrender = uOb.AddComponent<MeshRenderer>();

                        mfilter.mesh = uMeshAndMat.Mesh;
                        mrender.material = uMeshAndMat.Material;

                        // Decompose Assimp transform into scale, rot and translaction 
                        Assimp.Vector3D aScale = new Assimp.Vector3D();
                        Assimp.Quaternion aQuat = new Assimp.Quaternion();
                        Assimp.Vector3D aTranslation = new Assimp.Vector3D();
                        node.Transform.Decompose(out aScale, out aQuat, out aTranslation);
                        var Scale = new Vector3(aScale.X * Gestalt.ScaleOffset.x, aScale.Y * Gestalt.ScaleOffset.y, aScale.Z * Gestalt.ScaleOffset.z);
                        uOb.transform.localScale = Scale;

                        if (root != null)
                        {
                            MeshSimplifier simplifier = new MeshSimplifier();
                            simplifier.Initialize(mfilter.mesh);

                            int originalTriangleCount = mfilter.mesh.triangles.Length / 3;
                            if (originalTriangleCount > 400)
                            {
                                float simplificationPercentage = 1 - Mathf.Min(Mathf.Pow(1 - (200f / originalTriangleCount), 2), 1f);
                                simplifier.SimplifyMesh(simplificationPercentage);
                            }

                            GameObject collider = new GameObject
                            {
                                // collider.transform.parent = subcomp;
                                layer = LayerMask.NameToLayer("PhysicsComponent"),
                                name = "Collider"
                            };
                            collider.transform.localScale = Scale;
                            // If you need to create a collider using the simplified mesh
                            MeshCollider meshCollider = collider.AddComponent<MeshCollider>();
                            if (meshCollider != null)
                            {
                                meshCollider.convex = true;
                                meshCollider.sharedMesh = simplifier.ToMesh();
                            }
                            collider.SetActive(false);
                            ColliderHolder.Add(collider);
                        }

                        // Convert Assimp transfrom into Unity transform and set transformation of game object 
                        UnityEngine.Quaternion uQuat = new UnityEngine.Quaternion(aQuat.X, aQuat.Y, aQuat.Z, aQuat.W);
                        var euler = uQuat.eulerAngles;
                        
                        uOb.transform.localPosition = new Vector3(aTranslation.X, aTranslation.Y, aTranslation.Z);
                        uOb.transform.localRotation = UnityEngine.Quaternion.Euler(euler.x, -euler.y, euler.z);

                        Lret.Add(uOb);
                    }
                }

                if (Lret.Count <= 0)
                {
                    Lret.Add(new GameObject() { name = "Blank" });
                }

                if (node.HasChildren)
                {
                    foreach (var cn in node.Children)
                    {
                        var uObChild = NodeToGameObject(cn, false);
                        int index = 0;
                        foreach (var c in uObChild)
                        {
                            c.transform.SetParent(Lret[index % Lret.Count].transform, false);
                            index++;
                        }
                    }
                }

                return Lret;
            }

            if (ret == null)
            {
                ret = NodeToGameObject(scene.RootNode).FirstOrDefault();
                ret.transform.localScale = Vector3.one;
                var copy = GameObject.Instantiate(ret);
                GameObject.DontDestroyOnLoad(copy);
                copy.SetActive(false);
                bool added = SavedMeshData.TryAdd(hash, (copy, ColliderHolder));
            }
            
        finish:

            if (root != null)
            {
                ArticulationBody articulationBody = PLibrary.Require.ComponentInChildren<ArticulationBody>(root);
                Transform subcomp = PLibrary.Require.ChildWithTag("CollidersGroup", articulationBody);

                foreach (var c in ColliderHolder)
                {
                    var colidercopy = GameObject.Instantiate(c);
                    colidercopy.SetActive(true);
                    colidercopy.transform.SetParent(subcomp);
                }
            }

            return ret;
        }
        internal enum Rotation
        {
            None = 0,
            Ninety = 90,
            OneEighty = 180,
            TwoSeventy = 270,
            VerticalFlip,
            HorizontalFlip
        }

        private static Texture2D LoadTexture(Stream stream, Color4D c, Stream AplhaStream = null, Rotation transform = Rotation.VerticalFlip)
        {
            var baseColor = new Color(c.R, c.G, c.B, c.A);

            // Load the image using StbImageSharp
            ImageResult result = ImageResult.FromStream(stream, ColorComponents.RedGreenBlueAlpha);
            ImageResult alpha = null;
            if (AplhaStream != null)
                alpha = ImageResult.FromStream(AplhaStream, ColorComponents.Grey);

            int width = (transform == Rotation.Ninety || transform == Rotation.TwoSeventy) ? result.Height : result.Width;
            int height = (transform == Rotation.Ninety || transform == Rotation.TwoSeventy) ? result.Width : result.Height;

            Texture2D texture = new Texture2D(width, height, TextureFormat.RGBAFloat, false);

            byte[] alphaOverride = null;
            bool overrideAlpha = false;
            if (alpha != null)
            {
                alphaOverride = alpha.Data;
                overrideAlpha = true;
            }

            for (int y = 0; y < result.Height; y++)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    int idx = (y * result.Width + x) * 4; // 4 because of RedGreenBlueAlpha
                    Color color = new Color(result.Data[idx] / 255f,
                                            result.Data[idx + 1] / 255f,
                                            result.Data[idx + 2] / 255f,
                                            overrideAlpha ? alphaOverride[y * result.Width + x] / 255f : result.Data[idx + 3] / 255f);

                    Color mixedColor = Color.Lerp(baseColor, color, color.a);

                    int newX, newY;
                    switch (transform)
                    {
                        case Rotation.Ninety:
                            newX = y;
                            newY = result.Width - 1 - x;
                            break;
                        case Rotation.OneEighty:
                            newX = result.Width - 1 - x;
                            newY = result.Height - 1 - y;
                            break;
                        case Rotation.TwoSeventy:
                            newX = result.Height - 1 - y;
                            newY = x;
                            break;
                        case Rotation.VerticalFlip:
                            newX = x;
                            newY = result.Height - 1 - y;
                            break;
                        case Rotation.HorizontalFlip:
                            newX = result.Width - 1 - x;
                            newY = y;
                            break;
                        default:
                            newX = x;
                            newY = y;
                            break;
                    }

                    texture.SetPixel(newX, newY, mixedColor);
                }
            }

            texture.Apply();
            return texture;
        }

        /*
        private static Texture2D LoadTexture(Stream stream, Color4D c)
        {
            var baseColor = new Color(c.R, c.G, c.B, c.A);

            // Load the image using StbImageSharp
            ImageResult result = ImageResult.FromStream(stream, ColorComponents.RedGreenBlueAlpha);
            Texture2D texture = new Texture2D(result.Width, result.Height, TextureFormat.RGBAFloat, false);

            for (int y = 0; y < result.Height; y++)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    int idx = (y * result.Width + x) * 4; // 4 because of RedGreenBlueAlpha
                    Color color = new Color(result.Data[idx] / 255f,
                                            result.Data[idx + 1] / 255f,
                                            result.Data[idx + 2] / 255f,
                                            result.Data[idx + 3] / 255f);

                    Color mixedColor = Color.Lerp(baseColor, color, color.a);
                    texture.SetPixel(x, y, mixedColor);
                }
            }

            texture.Apply();
            return texture;
        }*/

        private static Texture2D LoadTexture(byte[] byteArray, Color4D c)
        {
            using MemoryStream stream = new MemoryStream(byteArray);
            return LoadTexture(stream, c);
        }
    }
}
