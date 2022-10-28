﻿using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace AsImpL
{
    /// <summary>
    /// Build the game object hierarchy with meshes and materials from a DataSet and a MaterialData list.
    /// </summary>
    public class ObjectBuilder
    {
        /// <summary>
        /// Optional build options
        /// </summary>
        public ImportOptions buildOptions = null;
#if UNITY_EDITOR
        /// <summary>
        /// Alternative texture path used to route loading requests to a proper asset database folder.
        /// Set by <see cref="ObjectImporter"/>.
        /// </summary>
        public string alternativeTexPath = null;
#endif
        private BuildStatus buildStatus = new BuildStatus();
        private DataSet currDataSet;
        private GameObject currParentObj;
        private Dictionary<string, Material> currMaterials;
        private List<MaterialData> materialData;

        /// <summary>
        /// Get the indexed list of imported materials
        /// </summary>
        public Dictionary<string, Material> ImportedMaterials { get { return currMaterials; } }

        /// <summary>
        /// Get the number of imported materials or 0 if nothing has been imported.
        /// </summary>
        public int NumImportedMaterials { get { return currMaterials != null ? currMaterials.Count : 0; } }

        /// <summary>
        /// Check if large meshes (32 bit indices) are supported by the current configuration.
        /// </summary>
        public bool LargeMeshesSupported
        {
            get
            {
//#if UNITY_2017_3_OR_NEWER
                // GPU support for 32 bit indices is not guaranteed on all platforms;
                // for example Android devices with Mali-400 GPU do not support them.
                // This check is performed in Using32bitIndices().
                // If nothing is rendered on your device probably Using32bitIndices() must be updated.
                if (Using32bitIndices())
                {
                    return true;
                }
//#endif
                return false;
            }
        }

        private static int MAX_VERTICES_LIMIT_FOR_A_MESH = 65000;
        private static int MAX_INDICES_LIMIT_FOR_A_MESH = 65000;
        // maximum number of vertices that can be used for triangles
        private static int MAX_VERT_COUNT = (MAX_VERTICES_LIMIT_FOR_A_MESH - 2) / 3 * 3;

        private IShaderSelector _shaderSelector;
        public IShaderSelector ShaderSelector
        {
            get { return _shaderSelector ?? (_shaderSelector = new ShaderSelector()); }
            set { _shaderSelector = value; }
        }

        private IMaterialFactory _materialFactory;
        public IMaterialFactory MaterialFactory
        {
            get { return _materialFactory ?? (_materialFactory = new MaterialFactory()); }
            set { _materialFactory = value; }
        }

        private bool DoubleSidedEnabled
        {
            get { return buildOptions != null && buildOptions.convertToDoubleSided; }
        }


        /// <summary>
        /// Initialize the importing of materials
        /// </summary>
        /// <param name="materialData">List of material data</param>
        /// <param name="hasColors">If true and materialData is null and vertex colors are available, then use them</param>
        public void InitBuildMaterials(List<MaterialData> materialData, bool hasColors, ModelReferences modelRefs)
        {
            this.materialData = materialData;
            currMaterials = new Dictionary<string, Material>();
            if (materialData == null || materialData.Count == 0)
            {
                string shaderName = "VertexLit";
                if (hasColors)
                {
                    shaderName = "Unlit/Simple Vertex Colors Shader";
                    if (Shader.Find(shaderName) == null)
                    {
                        shaderName = "Mobile/Particles/Alpha Blended";
                    }
                    Debug.Log("No material library defined. Using vertex colors.");
                }
                else
                {
                    Debug.LogWarning("No material library defined. Using a default material.");
                }
                Material newMaterial = MaterialFactory.Create(shaderName);
                modelRefs.AddMaterial(newMaterial);
                currMaterials.Add("default", newMaterial);
            }
        }


        /// <summary>
        /// Import materials step by step. Call this until it returns false.
        /// </summary>
        /// <param name="info">Progress information to be updated</param>
        /// <returns>Return true if in progress, false otherwise.</returns>
        public bool BuildMaterials(ProgressInfo info, ModelReferences modelRefs)
        {
            if (materialData == null)
            {
                Debug.LogWarning("No material library defined.");
                return false;
            }
            if (info.materialsLoaded >= materialData.Count)
            {
                return false;
            }
            MaterialData matData = materialData[info.materialsLoaded];
            info.materialsLoaded++;
            if (currMaterials.ContainsKey(matData.materialName))
            {
                Debug.LogWarning("Duplicate material found: " + matData.materialName + ". Repeated occurrence ignored");
            }
            else
            {
                currMaterials.Add(matData.materialName, BuildMaterial(matData, modelRefs));
            }
            return info.materialsLoaded < materialData.Count;
        }


        /// <summary>
        /// Initialize the asynchronous objects building.
        /// Call this once before calling StartBuildObjectAsync().
        /// </summary>
        /// <param name="dataSet">data set used to build the object</param>
        /// <param name="parentObj">game object to which the object will be attached</param>
        /// <param name="materials">dictionary mapping from material name to material</param>
        public void StartBuildObjectAsync(DataSet dataSet, GameObject parentObj, Dictionary<string, Material> materials = null)
        {
            currDataSet = dataSet;
            currParentObj = parentObj;
            if (materials != null)
            {
                currMaterials = materials;
            }
        }


        /// <summary>
        /// Build an object in more steps, one game object at a time.
        /// Call StartBuildObjectAsync() once, then call this until it returns true.
        /// </summary>
        /// <param name="info">progress information data updated on each call</param>
        /// <returns></returns>
        public bool BuildObjectAsync(ref ProgressInfo info)
        {
            bool result = BuildNextObject(currParentObj, currMaterials);
            info.objectsLoaded = buildStatus.objCount;
            info.groupsLoaded = buildStatus.subObjCount;
            info.numGroups = buildStatus.numGroups;
            return result;
        }


        /// <summary>
        /// Calculate tangent space vectors for a mesh.
        /// <see cref="http://forum.unity3d.com/threads/how-to-calculate-mesh-tangents.38984/"/>
        /// </summary>
        /// <param name="origMesh">Mesh to be filled with tangents</param>
        /// TODO: move this to a general utility class?
        public static void Solve(Mesh origMesh)
        {
            if (origMesh.uv == null || origMesh.uv.Length == 0)
            {
                Debug.LogWarning("Unable to compute tangent space vectors - texture coordinates not defined.");
                return;
            }
            if (origMesh.vertices == null || origMesh.vertices.Length == 0)
            {
                Debug.LogWarning("Unable to compute tangent space vectors - vertices not defined.");
                return;
            }
            if (origMesh.normals == null || origMesh.normals.Length == 0)
            {
                Debug.LogWarning("Unable to compute tangent space vectors - normals not defined.");
                return;
            }
            if (origMesh.triangles == null || origMesh.triangles.Length == 0)
            {
                Debug.LogWarning("Unable to compute tangent space vectors - triangles not defined.");
                return;
            }
            Vector3[] vertices = origMesh.vertices;
            Vector3[] normals = origMesh.normals;
            Vector2[] texcoords = origMesh.uv;
            int[] triangles = origMesh.triangles;
            int triVertCount = origMesh.triangles.Length;
            int maxVertIdx = -1;
            for (int i = 0; i < triangles.Length; i++)
            {
                if (maxVertIdx < triangles[i])
                {
                    maxVertIdx = triangles[i];
                }
            }
            if (vertices.Length <= maxVertIdx)
            {
                Debug.LogWarning("Unable to compute tangent space vectors - not enough vertices: " + vertices.Length.ToString());
                return;
            }
            if (normals.Length <= maxVertIdx)
            {
                Debug.LogWarning("Unable to compute tangent space vectors - not enough normals.");
                return;
            }
            if (texcoords.Length <= maxVertIdx)
            {
                Debug.LogWarning("Unable to compute tangent space vectors - not enough UVs.");
                return;
            }

            int vertexCount = origMesh.vertexCount;
            Vector4[] tangents = new Vector4[vertexCount];
            Vector3[] tan1 = new Vector3[vertexCount];
            Vector3[] tan2 = new Vector3[vertexCount];

            int triangleCount = triangles.Length / 3;
            int tri = 0;

            for (int i = 0; i < triangleCount; i++)
            {
                int i1 = triangles[tri];
                int i2 = triangles[tri + 1];
                int i3 = triangles[tri + 2];

                Vector3 v1 = vertices[i1];
                Vector3 v2 = vertices[i2];
                Vector3 v3 = vertices[i3];

                Vector2 w1 = texcoords[i1];
                Vector2 w2 = texcoords[i2];
                Vector2 w3 = texcoords[i3];

                float x1 = v2.x - v1.x;
                float x2 = v3.x - v1.x;
                float y1 = v2.y - v1.y;
                float y2 = v3.y - v1.y;
                float z1 = v2.z - v1.z;
                float z2 = v3.z - v1.z;

                float s1 = w2.x - w1.x;
                float s2 = w3.x - w1.x;
                float t1 = w2.y - w1.y;
                float t2 = w3.y - w1.y;

                float r = 1.0f / (s1 * t2 - s2 * t1);
                Vector3 sdir = new Vector3((t2 * x1 - t1 * x2) * r, (t2 * y1 - t1 * y2) * r, (t2 * z1 - t1 * z2) * r);
                Vector3 tdir = new Vector3((s1 * x2 - s2 * x1) * r, (s1 * y2 - s2 * y1) * r, (s1 * z2 - s2 * z1) * r);

                tan1[i1] += sdir;
                tan1[i2] += sdir;
                tan1[i3] += sdir;

                tan2[i1] += tdir;
                tan2[i2] += tdir;
                tan2[i3] += tdir;

                tri += 3;
            }

            for (int i = 0; i < vertexCount; i++)
            {
                Vector3 n = normals[i];
                Vector3 t = tan1[i];

                // Gram-Schmidt orthogonalize
                Vector3.OrthoNormalize(ref n, ref t);

                tangents[i].x = t.x;
                tangents[i].y = t.y;
                tangents[i].z = t.z;

                // Calculate handedness
                tangents[i].w = (Vector3.Dot(Vector3.Cross(n, t), tan2[i]) < 0.0f) ? -1.0f : 1.0f;
            }

            origMesh.tangents = tangents;
        }


        /// <summary>
        /// Build mesh colliders for objects with a mesh filter.
        /// </summary>
        /// <param name="targetObject">Game object to process (if it hasn't a mesh filter nothing happens)</param>
        /// <param name="convex">Build a convex mesh collider.</param>
        /// <param name="isTrigger">Set collider as "trigger"</param>
        /// <param name="inflateMesh">Inflate the convex mesh</param>
        /// <param name="skinWidth">Amount to be inflated</param>
        public static void BuildMeshCollider(GameObject targetObject, bool convex = false, bool isTrigger = false, bool inflateMesh = false, float skinWidth = 0.01f)
        {
            MeshFilter meshFilter = targetObject.GetComponent<MeshFilter>();
            if (meshFilter != null && meshFilter.sharedMesh != null)
            {
                Mesh objectMesh = meshFilter.sharedMesh;
                MeshCollider meshCollider = targetObject.AddComponent<MeshCollider>();

                // Note: the order of these assignments is important
                meshCollider.sharedMesh = objectMesh;
                if (convex)
                {
#if !UNITY_2018_3_OR_NEWER
                    meshCollider.skinWidth = skinWidth;
                    meshCollider.inflateMesh = inflateMesh;
#endif
                    meshCollider.convex = convex;
                    meshCollider.isTrigger = isTrigger;
                }
            }
        }


        /// <summary>
        /// Check if the given object data must be split into sub-objects.
        /// </summary>
        /// <param name="objData">object data to be checked</param>
        /// <returns>true only if the given object data must be split.</returns>
        protected bool MeshSplitNeeded(DataSet.ObjectData objData)
        {
            if (LargeMeshesSupported)
            {
                return false;
            }
            if (currDataSet.vertList.Count > MAX_VERTICES_LIMIT_FOR_A_MESH)
            {
                return true;
            }

            int maxIdx4mesh = DoubleSidedEnabled ? MAX_INDICES_LIMIT_FOR_A_MESH / 2 : MAX_INDICES_LIMIT_FOR_A_MESH;
            DataSet.FaceGroupData faceGroup = objData.faceGroups[buildStatus.grpIdx];
            if (faceGroup.faces.Count > maxIdx4mesh)
            {
                return true;
            }

            return false;
        }


        /// <summary>
        /// Build an object once at a time, to be reiterated until false is returned.
        /// </summary>
        /// <param name="parentObj">Game object to which the new objects will be attached</param>
        /// <param name="mats">Materials from the previously loaded library</param>
        /// <returns>Return true until no more objects can be added, then false.</returns>
        protected bool BuildNextObject(GameObject parentObj, Dictionary<string, Material> mats)
        {
            // if all the objects were built stop here
            if (buildStatus.objCount >= currDataSet.objectList.Count)
            {
                return false;
            }

            // get the next object in the list
            DataSet.ObjectData objData = currDataSet.objectList[buildStatus.objCount];

            if (buildStatus.newObject)
            {
                SetUpNewObject(parentObj, objData);
            }

            if ((buildOptions != null && buildOptions.splitByMaterial) || MeshSplitNeeded(objData))
            {
                BuildCurrentPart(objData, mats);
            }
            else
            {
                BuildCurrentMesh(objData, mats);
            }

            buildStatus.subObjCount++;

            if (buildStatus.totFaceIdxCount >= objData.allFaces.Count || buildStatus.grpIdx >= objData.faceGroups.Count)
            {
                if (buildStatus.totFaceIdxCount != objData.allFaces.Count)
                {
                    Debug.LogWarningFormat("Imported face indices: {0} of {1}", buildStatus.totFaceIdxCount, objData.allFaces.Count);
                    return false;
                }

                buildStatus.objCount++;
                buildStatus.newObject = true;
            }

            return true;
        }

        /// <summary>
        /// Set up an object to be built.
        /// </summary>
        /// <param name="parentObj">The "container" object for this object (a mesh can be also directly added to it).</param>
        /// <param name="objData">object data</param>
        protected void SetUpNewObject(GameObject parentObj, DataSet.ObjectData objData)
        {
            if (buildStatus.objCount == 0 && objData.name == "default")
            {
                buildStatus.currObjGameObject = parentObj;
            }
            else
            {
                buildStatus.currObjGameObject = new GameObject();
                buildStatus.currObjGameObject.transform.parent = parentObj.transform;
                buildStatus.currObjGameObject.name = objData.name;
                // restore the scale if the parent was rescaled
                buildStatus.currObjGameObject.transform.localScale = Vector3.one;
            }
            buildStatus.subObjParent = buildStatus.currObjGameObject;

            buildStatus.newObject = false;
            buildStatus.subObjCount = 0;
            buildStatus.idxCount = 0;
            buildStatus.grpIdx = 0;
            buildStatus.grpFaceIdx = 0;
            buildStatus.meshPartIdx = 0;
            buildStatus.totFaceIdxCount = 0;
            buildStatus.numGroups = Mathf.Max(1, objData.faceGroups.Count);
        }


        /// <summary>
        /// Build the current part (called if the splitByMaterial option is set).
        /// </summary>
        /// <param name="objData">Object data.</param>
        /// <param name="matLib">Material library.</param>
        protected void BuildCurrentPart(DataSet.ObjectData objData, Dictionary<string, Material> matLib)
        {
            bool splitLargeMeshes = !LargeMeshesSupported;

            bool splitGrp = false;

            DataSet.FaceGroupData faceGroup = objData.faceGroups[buildStatus.grpIdx];

            DataSet.FaceGroupData grp = new DataSet.FaceGroupData();
            grp.name = faceGroup.name;
            grp.materialName = faceGroup.materialName;


            // data for sub-object
            DataSet.ObjectData subObjData = new DataSet.ObjectData();
            subObjData.hasNormals = objData.hasNormals;
            subObjData.hasColors = objData.hasColors;

            HashSet<int> vertIdxSet = new HashSet<int>();

            bool conv2sided = buildOptions != null && buildOptions.convertToDoubleSided;

            int maxIdx4mesh = conv2sided ? MAX_INDICES_LIMIT_FOR_A_MESH / 2 : MAX_INDICES_LIMIT_FOR_A_MESH;

            // copy blocks of face indices to each sub-object data
            for (int f = buildStatus.grpFaceIdx; f < faceGroup.faces.Count; f++)
            {
                // if large meshed must be split and
                // if passed the max number of vertices and not at the last iteration
                if (splitLargeMeshes && (vertIdxSet.Count / 3 > MAX_VERT_COUNT / 3 || subObjData.allFaces.Count / 3 > maxIdx4mesh / 3))
                {
                    // split the group across more objects
                    splitGrp = true;
                    buildStatus.grpFaceIdx = f;
                    Debug.LogWarningFormat("Maximum vertex number for a mesh exceeded.\nSplitting object {0} (group {1}, starting from index {2})...", grp.name, buildStatus.grpIdx, f);
                    break;
                }
                DataSet.FaceIndices fi = faceGroup.faces[f];
                subObjData.allFaces.Add(fi);
                grp.faces.Add(fi);
                vertIdxSet.Add(fi.vertIdx);
            }

            if (splitGrp || buildStatus.meshPartIdx > 0)
            {
                buildStatus.meshPartIdx++;
            }

            // create an empty (group) object in case the group has been split
            if (buildStatus.meshPartIdx == 1)
            {
                GameObject grpObj = new GameObject();
                grpObj.transform.SetParent(buildStatus.currObjGameObject.transform, false);
                grpObj.name = grp.name;
                buildStatus.subObjParent = grpObj;
            }

            // add a suffix to the group name in case the group has been split
            if (buildStatus.meshPartIdx > 0)
            {
                grp.name = buildStatus.subObjParent.name + "_MeshPart" + buildStatus.meshPartIdx;
            }
            subObjData.name = grp.name;

            // add the group to the sub object data
            subObjData.faceGroups.Add(grp);

            // update the start index
            buildStatus.idxCount += subObjData.allFaces.Count;

            if (!splitGrp)
            {
                buildStatus.grpFaceIdx = 0;
                buildStatus.grpIdx++;
            }
            buildStatus.totFaceIdxCount += subObjData.allFaces.Count;

            GameObject subobj = ImportSubObject(buildStatus.subObjParent, subObjData, matLib);
            if (subobj == null)
            {
                Debug.LogWarningFormat("Error loading sub object n.{0}.", buildStatus.subObjCount);
            }
            //else Debug.LogFormat( "Imported face indices: {0} to {1}", buildStatus.totFaceIdxCount - sub_od.AllFaces.Count, buildStatus.totFaceIdxCount );
        }


        /// <summary>
        /// Build a sub-object of the current part (called if the splitByMaterial option is set).
        /// </summary>
        /// <param name="parentObj"></param>
        /// <param name="objData">Object data.</param>
        /// <param name="matLib">Material library.</param>
        /// <returns>The GameObject created for the sub object.</returns>
        protected GameObject ImportSubObject(GameObject parentObj, DataSet.ObjectData objData, Dictionary<string, Material> matLib)
        {
            GameObject go = new GameObject();
            go.name = objData.name;
			
			// make the object name unique, adding a progressive number if needed
            int count = 0;
            if (parentObj.transform)
            {
                while (parentObj.transform.Find(go.name))
                {
                    count++;
                    go.name = objData.name + count;
                }
            }
            go.transform.SetParent(parentObj.transform, false);

            if (objData.allFaces.Count == 0)
            {
                Debug.LogWarning("Sub object: " + objData.name + " has no face defined. Creating empty game object.");

                return go;
            }

            //Debug.Log( "Importing sub object:" + objData.Name );


            go.AddComponent<MeshFilter>();
            go.AddComponent<MeshRenderer>();

            Renderer renderer = go.GetComponent<Renderer>();

            Mesh mesh = BuildMesh(renderer, objData, matLib);
			
			FinalizeObject(go,mesh);

            return go;
        }


        /// <summary>
        /// Build the mesh for the current object (called if the splitByMaterial option is NOT set).
        /// </summary>
        /// <param name="objData">Object data.</param>
        /// <param name="matLib">Material library.</param>
        protected void BuildCurrentMesh(DataSet.ObjectData objData, Dictionary<string, Material> matLib)
        {
            if (objData.allFaces.Count == 0)
            {
                Debug.LogWarning("Object: " + objData.name + " has no face defined.");
                return;
            }
            DataSet.FaceGroupData faceGroup = objData.faceGroups[buildStatus.grpIdx];
            GameObject go = buildStatus.currObjGameObject;
            go.AddComponent<MeshFilter>();
            go.AddComponent<MeshRenderer>();

            Dictionary<string, int> vIdxCount;
            Mesh mesh = CreateMesh(objData, out vIdxCount);
            mesh.subMeshCount = objData.faceGroups.Count;

            Material[] faceMaterials = new Material[objData.faceGroups.Count];
            for (int i = 0; i < objData.faceGroups.Count; i++)
            {
                Material material = GetLibraryMaterial(matLib, objData.faceGroups[i].materialName);

                faceMaterials[i] = material;

                int numIndices = BuildSubMesh(mesh, objData, vIdxCount, i);

                buildStatus.grpFaceIdx = 0;
                buildStatus.grpIdx++;
                buildStatus.totFaceIdxCount += numIndices;
            }

            Renderer renderer = go.GetComponent<Renderer>();

            renderer.materials = faceMaterials;
            ModelUtil.UpdateRendererMaterials(renderer);

            FinalizeMesh(mesh, objData.hasNormals);

			FinalizeObject(go, mesh);
            // update the start index
            //buildStatus.idxCount += objData.faceGroups.Count;

        }


        /// <summary>
        /// Build and set up a mesh (always called when building an object).
        /// </summary>
        /// <param name="renderer">Renderer where mesh materials are added.</param>
        /// <param name="objData">Object data.</param>
        /// <param name="matLib">Material library.</param>
        /// <returns>A new mesh, its materials are added to the given renderer.</returns>
        protected Mesh BuildMesh(Renderer renderer, DataSet.ObjectData objData, Dictionary<string, Material> matLib)
        {
            Dictionary<string, int> vIdxCount;
            Mesh mesh = CreateMesh(objData, out vIdxCount);

            Material material = GetLibraryMaterial(matLib, objData.faceGroups[0].materialName);

            if (material != null)
            {
                renderer.sharedMaterial = material;
                ModelUtil.UpdateRendererMaterials(renderer);
            }

            BuildSubMesh(mesh, objData, vIdxCount, 0);

            FinalizeMesh(mesh, objData.hasNormals);

            return mesh;
        }


        /// <summary>
        /// Create a mesh with only vertices information defined.
        /// </summary>
        /// <param name="objData">Object data.</param>
        /// <param name="vIdxCount">Counter for vertex info (position, UV, normal) to be shared among faces.</param>
        /// <returns>The created mesh with only vertices information defined.</returns>
        protected Mesh CreateMesh(DataSet.ObjectData objData, out Dictionary<string, int> vIdxCount)
        {
            bool conv2sided = DoubleSidedEnabled;

            // count vertices needed for all the faces and map face indices to new vertices
            vIdxCount = new Dictionary<string, int>();
            foreach (DataSet.FaceIndices fi in objData.allFaces)
            {
                string key = DataSet.GetFaceIndicesKey(fi);
                int idx;
                // avoid duplicates
                if (!vIdxCount.TryGetValue(key, out idx))
                {
                    vIdxCount.Add(key, vIdxCount.Count);
                }
            }
            int vcount = vIdxCount.Count;

            int arraySize = conv2sided ? vcount * 2 : vcount;

            Vector3[] newVertices = new Vector3[arraySize];
            Vector2[] newUVs = new Vector2[arraySize];
            Vector3[] newNormals = new Vector3[arraySize];
            Color32[] newColors = new Color32[arraySize];

            bool hasColors = currDataSet.colorList.Count > 0;

            foreach (DataSet.FaceIndices fi in objData.allFaces)
            {
                string key = DataSet.GetFaceIndicesKey(fi);
                int k = vIdxCount[key];
                newVertices[k] = currDataSet.vertList[fi.vertIdx];
                if (conv2sided)
                {
                    newVertices[vcount + k] = newVertices[k];
                }
                if (hasColors)
                {
                    newColors[k] = currDataSet.colorList[fi.vertIdx];
                    if (conv2sided)
                    {
                        newColors[vcount + k] = newColors[k];
                    }
                }
                if (currDataSet.uvList.Count > 0)
                {
                    newUVs[k] = currDataSet.uvList[fi.uvIdx];
                    if (conv2sided)
                    {
                        newUVs[vcount + k] = newUVs[k];
                    }
                }
                if (currDataSet.normalList.Count > 0 && fi.normIdx >= 0)
                {
                    newNormals[k] = currDataSet.normalList[fi.normIdx];
                    if (conv2sided)
                    {
                        newNormals[vcount + k] = -newNormals[k];
                    }
                }
            }

            Mesh mesh = new Mesh();

//#if UNITY_2017_3_OR_NEWER
            // Enable 32 bit indices only if needed
            if (Using32bitIndices())
            {
                int maxIndexCount = 0;
                for (int i = 0; i <objData.faceGroups.Count; i++)
                {
                    if (maxIndexCount < objData.faceGroups[i].faces.Count)
                    {
                        maxIndexCount = objData.faceGroups[i].faces.Count;
                    }
                }
                int numIndices = conv2sided ? maxIndexCount * 2 : maxIndexCount;

                if (arraySize > MAX_VERT_COUNT || numIndices > MAX_INDICES_LIMIT_FOR_A_MESH)
                {
                    mesh.indexFormat = UnityEngine.Rendering.IndexFormat.UInt32;
                }
            }
//#endif

            mesh.vertices = newVertices;
            bool objectHasNormals = (currDataSet.normalList.Count > 0 && objData.hasNormals);
            bool objectHasColors = (currDataSet.colorList.Count > 0 && objData.hasColors);
            bool objectHasUVs = (currDataSet.uvList.Count > 0);

            if (objectHasUVs) mesh.uv = newUVs;
            if (objectHasNormals) mesh.normals = newNormals;
            if (objectHasColors) mesh.colors32 = newColors;

            return mesh;
        }


        /// <summary>
        /// Build the faces for the given (sub)mesh according to the given data.
        /// </summary>
        /// <param name="mesh">The mesh to which the faces will be added.</param>
        /// <param name="objData">Object data.</param>
        /// <param name="vIdxCount">Counter for vertex info (position, UV, normal) to be shared among faces.</param>
        /// <param name="subMeshIndex">Index of the sub-mesh</param>
        /// <returns>The number of indices of the mesh (even in case of double sided option).</returns>
        protected int BuildSubMesh(Mesh mesh, DataSet.ObjectData objData, Dictionary<string, int> vIdxCount, int subMeshIndex)
        {
            int n = objData.faceGroups[subMeshIndex].faces.Count;
            bool conv2sided = DoubleSidedEnabled;
            int numIndices = conv2sided ? n * 2 : n;
            int[] indices = new int[numIndices];

            for (int s = 0; s < n; s++)
            {
                DataSet.FaceIndices fi = objData.faceGroups[subMeshIndex].faces[s];
                string key = DataSet.GetFaceIndicesKey(fi);
                indices[s] = vIdxCount[key];
            }
            if (conv2sided)
            {
                int vcount = vIdxCount.Count;
                for (int s = 0; s < n; s++)
                {
                    indices[s + n] = vcount + indices[s / 3 * 3 + 2 - s % 3];
                }
            }

            mesh.SetTriangles(indices, subMeshIndex);

            return numIndices;
        }


        /// <summary>
        /// Compute missing data for the given mesh.
        /// </summary>
        /// <param name="mesh">Existing mesh to be finalized.</param>
        /// <param name="objDataHasNormals">Flag to inform if nomals data is provided (or if it must be computed).</param>
        protected void FinalizeMesh(Mesh mesh, bool objDataHasNormals)
        {
            bool objectHasNormals = (currDataSet.normalList.Count > 0 && objDataHasNormals);
            bool objectHasUVs = (currDataSet.uvList.Count > 0);
            if (!objectHasNormals)
            {
                mesh.RecalculateNormals();
            }
            if (objectHasUVs)
            {
                Solve(mesh);
            }
       }


        /// <summary>
        /// Finalize the given object adding the given mesh (and updating its collider if needed).
        /// </summary>
        /// <param name="incompleteObj">Object to be completed and finalized.</param>
        /// <param name="mesh">Mesh to be added to the object.</param>
        protected void FinalizeObject(GameObject incompleteObj, Mesh mesh)
		{
            ModelReferences modelRefs = incompleteObj.GetComponentInParent<ModelReferences>();
            modelRefs.AddMesh(mesh);
            mesh.name = incompleteObj.name;
            MeshFilter meshFilter = incompleteObj.GetComponent<MeshFilter>();
            meshFilter.sharedMesh = mesh;

            if (buildOptions != null && buildOptions.buildColliders)
            {
//#if UNITY_2018_3_OR_NEWER
                BuildMeshCollider(incompleteObj, buildOptions.colliderConvex, buildOptions.colliderTrigger);
//#else
                //BuildMeshCollider(incompleteObj, buildOptions.colliderConvex, buildOptions.colliderTrigger, buildOptions.colliderInflate, buildOptions.colliderSkinWidth);
//#endif
            }
		}

        /// <summary>
        /// Get a material given its name and library (falling back to a default material if not found).
        /// </summary>
        /// <param name="materialLibrary">The dictionary containing the material library.</param>
        /// <param name="materialName">Name of the material.</param>
        /// <returns>The required material, a default material or null if no material is available.</returns>
        protected Material GetLibraryMaterial(Dictionary<string, Material> materialLibrary, string materialName)
        {
            Material material = null;
            string matName = (materialName != null) ? materialName : "default";

            if (materialLibrary.ContainsKey(matName))
            {
                material = materialLibrary[matName];
            }
            else
            {
                if (materialLibrary.ContainsKey("default"))
                {
                    material = materialLibrary["default"];
                    Debug.LogWarning("Material: " + matName + " not found. Using the default material.");
                }
                else
                {
                    Debug.LogError("Material: " + matName + " not found.");
                }
            }
            return material;
        }


        /// <summary>
        /// Build a Unity Material from MaterialData
        /// </summary>
        /// <param name="mtlData">material data</param>
        /// <returns>Unity material</returns>
        protected Material BuildMaterial(MaterialData mtlData, ModelReferences modelRefs)
        {
            bool specularMode = false;// (md.specularTex != null);
            ModelUtil.MtlBlendMode mode = mtlData.overallAlpha < 1.0f ? ModelUtil.MtlBlendMode.TRANSPARENT : ModelUtil.MtlBlendMode.OPAQUE;

            bool useUnlit = buildOptions != null && buildOptions.litDiffuse
                && mtlData.diffuseTex != null
                && mtlData.bumpTex == null
                && mtlData.opacityTex == null
                && mtlData.specularTex == null
                && !mtlData.hasReflectionTex;

            bool? diffuseIsTransparent = null;
            if (useUnlit)
            {
                // do not use unlit shader if the texture has transparent pixels
                diffuseIsTransparent = ModelUtil.ScanTransparentPixels(mtlData.diffuseTex, ref mode);
            }

            Material newMaterial = MaterialFactory.Create(ShaderSelector.Select(mtlData, useUnlit, mode)); // "Standard (Specular setup)"
            modelRefs.AddMaterial(newMaterial);
            newMaterial.name = mtlData.materialName;

            float shinLog = Mathf.Log(mtlData.shininess, 2);
            // get the metallic value from the shininess
            float metallic = Mathf.Clamp01(shinLog / 10.0f);
            // get the smoothness from the shininess
            float smoothness = Mathf.Clamp01(shinLog / 10.0f);
            if (specularMode)
            {
                newMaterial.SetColor("_SpecColor", mtlData.specularColor);
                newMaterial.SetFloat("_Shininess", mtlData.shininess / 1000.0f);
                //m.color = new Color( md.diffuse.r, md.diffuse.g, md.diffuse.b, md.alpha);
            }
            else
            {
                newMaterial.SetFloat("_Metallic", metallic);
                //m.SetFloat( "_Glossiness", md.shininess );
            }


            if (mtlData.diffuseTex != null)
            {
                // diffuse

                if (mtlData.opacityTex != null)
                {
                    // diffuse + opacity:
                    // update diffuse texture if an opacity map was found
                    int w = mtlData.diffuseTex.width;
                    int h = mtlData.diffuseTex.width;
                    Texture2D albedoTexture = new Texture2D(w, h, TextureFormat.ARGB32, false);
                    modelRefs.AddTexture(albedoTexture);
                    Color col = new Color();
                    for (int x = 0; x < albedoTexture.width; x++)
                    {
                        for (int y = 0; y < albedoTexture.height; y++)
                        {
                            col = mtlData.diffuseTex.GetPixel(x, y);
                            col.a *= mtlData.opacityTex.GetPixel(x, y).grayscale;
                            // blend diffuse and opacity textures
                            albedoTexture.SetPixel(x, y, col);
                        }
                    }
                    albedoTexture.name = mtlData.diffuseTexPath;
                    albedoTexture.Apply();
                    // mode = ModelUtil.MtlBlendMode.TRANSPARENT;
                    // The map_d value is multiplied by the d value --> Fade mode
                    mode = ModelUtil.MtlBlendMode.FADE;
#if UNITY_EDITOR
                    if (!string.IsNullOrEmpty(alternativeTexPath))
                    {
                        string texAssetPath = AssetDatabase.GetAssetPath(mtlData.opacityTex);
                        if (!string.IsNullOrEmpty(texAssetPath))
                        {
                            EditorUtil.SaveAndReimportPngTexture(ref albedoTexture, texAssetPath, "_alpha");
                        }
                    }
#endif
                    newMaterial.SetTexture("_MainTex", albedoTexture);
                }
                else
                {// md.opacityTex == null

                    // diffuse without opacity: if there are transparent pixels ==> transparent material
                    if (!diffuseIsTransparent.HasValue)
                    {
                        diffuseIsTransparent = ModelUtil.ScanTransparentPixels(mtlData.diffuseTex, ref mode);
                    }
                    newMaterial.SetTexture("_MainTex", mtlData.diffuseTex);
                }
                //Debug.LogFormat("Diffuse set for {0}",m.name);
            }
            else if (mtlData.opacityTex != null)
            {
                // opacity without diffuse
                //mode = ModelUtil.MtlBlendMode.TRANSPARENT;
                mode = ModelUtil.MtlBlendMode.FADE;
                int w = mtlData.opacityTex.width;
                int h = mtlData.opacityTex.width;
                Texture2D albedoTexture = new Texture2D(w, h, TextureFormat.ARGB32, false);
                modelRefs.AddTexture(albedoTexture);
                Color col = new Color();
                bool detected = false;
                for (int x = 0; x < albedoTexture.width; x++)
                {
                    for (int y = 0; y < albedoTexture.height; y++)
                    {
                        col = mtlData.diffuseColor;
                        col.a = mtlData.overallAlpha * mtlData.opacityTex.GetPixel(x, y).grayscale;
                        ModelUtil.DetectMtlBlendFadeOrCutout(col.a, ref mode, ref detected);
                        //if (md.alpha == 1.0f && col.a == 0.0f) mode = ModelUtil.MtlBlendMode.CUTOUT;
                        albedoTexture.SetPixel(x, y, col);
                    }
                }
                albedoTexture.name = mtlData.diffuseTexPath;
                albedoTexture.Apply();
#if UNITY_EDITOR
                if (!string.IsNullOrEmpty(alternativeTexPath))
                {
                    string texAssetPath = AssetDatabase.GetAssetPath(mtlData.opacityTex);
                    if (!string.IsNullOrEmpty(texAssetPath))
                    {
                        EditorUtil.SaveAndReimportPngTexture(ref albedoTexture, texAssetPath, "_op");
                    }
                }
#endif
                newMaterial.SetTexture("_MainTex", albedoTexture);
            }

            mtlData.diffuseColor.a = mtlData.overallAlpha;
            newMaterial.SetColor("_Color", mtlData.diffuseColor);

            mtlData.emissiveColor.a = mtlData.overallAlpha;
            newMaterial.SetColor("_EmissionColor", mtlData.emissiveColor);
            if (mtlData.emissiveColor.r > 0 || mtlData.emissiveColor.g > 0 || mtlData.emissiveColor.b > 0)
            {
                newMaterial.EnableKeyword("_EMISSION");
            }

            if (mtlData.bumpTex != null)
            {
                // bump map defined

                // TODO: if importing assets do not create a normal map, change importer settings

                // let (improperly) assign a normal map to the bump map
                // if the file name contains a specific tag
                // TODO: customize normal map tag
                if (mtlData.bumpTexPath.Contains("_normal_map"))
                {
                    newMaterial.EnableKeyword("_NORMALMAP");
                    newMaterial.SetFloat("_BumpScale", 0.25f); // lower the bump effect with the normal map
                    newMaterial.SetTexture("_BumpMap", mtlData.bumpTex);
                }
                else
                {
                    // calculate normal map
                    Texture2D normalMap = ModelUtil.HeightToNormalMap(mtlData.bumpTex);
                    modelRefs.AddTexture(normalMap);
#if UNITY_EDITOR
                    if (!string.IsNullOrEmpty(alternativeTexPath))
                    {
                        string texAssetPath = AssetDatabase.GetAssetPath(mtlData.bumpTex);
                        if (!string.IsNullOrEmpty(texAssetPath))
                        {
                            EditorUtil.SaveAndReimportPngTexture(ref normalMap, texAssetPath, "_nm", true);
                        }
                    }
                    else
#endif
                    {
                        newMaterial.SetTexture("_BumpMap", normalMap);
                        //newMaterial.SetTexture("_BumpMap", md.bumpTex);
                        newMaterial.EnableKeyword("_NORMALMAP");
                        newMaterial.SetFloat("_BumpScale", 1.0f); // adjust the bump effect with the normal map
                    }
                }
            }

            if (mtlData.specularTex != null)
            {
                Texture2D glossTexture = new Texture2D(mtlData.specularTex.width, mtlData.specularTex.height, TextureFormat.ARGB32, false);
                modelRefs.AddTexture(glossTexture);
                Color col = new Color();
                float pix = 0.0f;
                for (int x = 0; x < glossTexture.width; x++)
                {
                    for (int y = 0; y < glossTexture.height; y++)
                    {
                        pix = mtlData.specularTex.GetPixel(x, y).grayscale;

                        // red = metallic

                        col.r = metallic * pix;// md.specular.grayscale*pix;
                        col.g = col.r;
                        col.b = col.r;

                        // alpha = smoothness

                        // if reflecting set maximum smoothness value, else use a precomputed value
                        if (mtlData.hasReflectionTex) col.a = pix;
                        else col.a = pix * smoothness;

                        glossTexture.SetPixel(x, y, col);
                    }
                }
                glossTexture.Apply();
#if UNITY_EDITOR
                if (!string.IsNullOrEmpty(alternativeTexPath))
                {
                    string texAssetPath = AssetDatabase.GetAssetPath(mtlData.specularTex);
                    if (!string.IsNullOrEmpty(texAssetPath))
                    {
                        EditorUtil.SaveAndReimportPngTexture(ref glossTexture, texAssetPath, "_spec");
                    }
                }
#endif

                if (specularMode)
                {
                    newMaterial.EnableKeyword("_SPECGLOSSMAP");
                    newMaterial.SetTexture("_SpecGlossMap", glossTexture);
                }
                else
                {
                    newMaterial.EnableKeyword("_METALLICGLOSSMAP");
                    newMaterial.SetTexture("_MetallicGlossMap", glossTexture);
                }

                //m.SetTexture( "_MetallicGlossMap", md.specularLevelTex );
            }

            // replace the texture with Unity environment reflection
            if (mtlData.hasReflectionTex)
            {
                if (mtlData.overallAlpha < 1.0f)
                {
                    Color col = Color.white;
                    col.a = mtlData.overallAlpha;
                    newMaterial.SetColor("_Color", col);
                    mode = ModelUtil.MtlBlendMode.FADE;
                }
                // the "amount of" info is missing, using a default value
                if (mtlData.specularTex != null)
                {
                    newMaterial.SetFloat("_Metallic", metallic);// 1.0f);
                }
                // usually the reflection texture is not blurred
                newMaterial.SetFloat("_Glossiness", 1.0f);
            }

            ModelUtil.SetupMaterialWithBlendMode(newMaterial, mode);

            //#if UNITY_EDITOR
            //        if (!string.IsNullOrEmpty(alternateTexPath))
            //        {
            //            string path = alternateTexPath + "../Materials/" + m.name + ".mat";
            //            path = path.Replace("Textures/../", "");
            //            Debug.LogFormat("Creating material asset in {0}", path);
            //            AssetDatabase.CreateAsset(m, path);
            //        m = AssetDatabase.LoadAssetAtPath<Material>(path);
            //        }
            //#endif
            return newMaterial;
        }


//#if UNITY_2017_3_OR_NEWER
        /// <summary>
        /// Check if the GPU support for 32 bit indices is enabled and available.
        /// </summary>
        /// <remarks>
        /// GPU support for 32 bit indices is not guaranteed on all platforms;
        /// for example Android devices with Mali-400 GPU do not support them.
        /// </remarks>
        /// <returns>True if the GPU support for 32 bit indices is enabled and available.</returns>
        private bool Using32bitIndices()
        {
            if (buildOptions != null && !buildOptions.use32bitIndices)
            {
                // Do not use at all 32 bit indices only if explicitly required.
                return false;
            }
#if UNITY_ANDROID
            string graphicsDeviceName = SystemInfo.graphicsDeviceName;
            // If nothing is rendered on your device probably a new device check must be added here.
            if (graphicsDeviceName.Contains("Mali") && graphicsDeviceName.Contains("400"))
            {
                // Android devices with Mali-400 GPU do not support 32 bit indices
                return false;
            }
#endif
            return true;
        }
//#endif


        public class ProgressInfo
        {
            public int materialsLoaded = 0;
            public int objectsLoaded = 0;
            public int groupsLoaded = 0;
            public int numGroups = 0;
        }


        private class BuildStatus
        {
            // true if a new object must be created
            public bool newObject = true;

            // counter for objects
            public int objCount = 0;

            // counter for sub objects
            public int subObjCount = 0;

            // number of added indices
            public int idxCount = 0;

            // index of the last group
            public int grpIdx = 0;

            // number of the groups for the last object
            public int numGroups = 0;

            // index of the first face index in the group
            public int grpFaceIdx = 0;

            // index of the last mesh part if the group is split into parts
            public int meshPartIdx = 0;

            // total number of face indices processed
            public int totFaceIdxCount = 0;

            // current OBJ object
            public GameObject currObjGameObject = null;
            internal GameObject subObjParent;
        }

    }
}
