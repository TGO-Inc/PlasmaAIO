extern alias GameClass;
extern alias PLibrary;
using Microsoft.Win32;
using Plasma.API;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using StbImageSharp;
using System.Drawing;
using System.Drawing.Imaging;
using System;
using Plasma.Application.Extensions;
using Plasma.API.Classes;
using Assimp;
using Plasma.Application.Game;
using UnityEngine;
using Plasma.Application.InternalClass;
using System.Linq;
using static GameClass::AgentGestalt;

namespace Plasma.Mods.ScrapMechanicMod
{
    public class Initialization
    {
        private static readonly string[] IconTextureMapping = new string[]
        {
            "Dif",
            "Asg",
            "Nor",
        };
        public Initialization()
        {
            /*
             * my vars here
             */
        }
        // public static void Main() => new Initialization().Start();

        public void Start()
        {
            /*
            * start hooks here
            */
            string GameDir = GetGameDir();
            var files = DirectoryProcessor.FindAllDatabaseFiles(GameDir);
            var content = DataProcessor.ProcessPartListFiles(files, GameDir);
            var previews = IconMapProcessor.ExtractIconData(GameDir);
            var descriptions = InventoryDescriptionLoader.LoadDescriptions(GameDir);


            foreach (var item in content)
            {
                //var item = content[22];

                if (previews.TryGetValue(item.UUID.ToUpperInvariant(), out var preview) && descriptions.TryGetValue(item.UUID.ToUpperInvariant(), out var info))
                {
                    ComponentManager.NewDyanamicComponent(new object[] { item, preview, info }, DynamicInstanceCreator);
                    //break;
                }
            }

            //var preview = previews.First();
            //SaveImageToWorkingDirectory(preview.Image, preview.UUID + ".png");
            //Console.WriteLine(JsonConvert.SerializeObject(content, Formatting.Indented));
            //Console.ReadLine();
        }

        public static bool DynamicInstanceCreator(DynamicGestalt instance, object[] indt)
        {
            DataProcessor.PartData part = indt[0] as DataProcessor.PartData;
            IconMapProcessor.IconInfo preview = indt[1] as IconMapProcessor.IconInfo;
            (string DisplayName, string Description) = ((string, string))indt[2];

            Guid guid = Guid.Parse(part.UUID);
            var customTextureData = new CustomTextureOverride()
            {
                BaseColor = IconMapProcessor.ConvertHexToNormalizedRGBA(part.Color),
                MaterialName = "ANY"//part.Name.Split('_')[^1]
            };

            var targetRend = part.Renderable[0];
            var currentIndex = 0;
            var result = new Dictionary<string, string>();
            for (int i = 0; i < targetRend.MaterialType.Length - 2; i++)
            {
                var abbreviation = targetRend.MaterialType.Substring(i, 3);
                if (IconTextureMapping.Contains(abbreviation))
                {
                    result[abbreviation] = targetRend.TexturePaths[currentIndex];
                    currentIndex++;
                    if (currentIndex >= targetRend.TexturePaths.Count)
                        break;
                    i += 2;  // Skip the next two characters since we've identified a texture abbreviation
                }
                // If not recognized, just continue with the loop.
            }
            var TextureStreams = new List<(string Path, ResourceStream Stream)>();

            foreach (var key in IconTextureMapping)
            {
                if (result.TryGetValue(key, out string path))
                {
                    string name = Path.GetFileName(path);
                    switch (key)
                    {
                        case "Dif":
                            customTextureData.Diffuse = new TextureSlot()
                            {
                                FilePath = name,
                                TextureType = TextureType.Diffuse
                            };
                            TextureStreams.Add((name, new ResourceStream(new MemoryStream(File.ReadAllBytes(path)))));
                            break;
                        case "Asg":
                            customTextureData.Specular = new TextureSlot()
                            {
                                FilePath = name,
                                TextureType = TextureType.Specular
                            };
                            TextureStreams.Add((name, new ResourceStream(new MemoryStream(File.ReadAllBytes(path)))));
                            break;
                        case "Nor":
                            customTextureData.Normal = new TextureSlot()
                            {
                                FilePath = name,
                                TextureType = TextureType.Normals
                            };
                            TextureStreams.Add((name, new ResourceStream(new MemoryStream(File.ReadAllBytes(path)))));
                            break;
                    }
                }
            }
            Texture2D uTexture = new Texture2D(preview.Image.Width, preview.Image.Height, TextureFormat.RGBA32, false);

            Color32[] colors = new Color32[preview.Image.Data.Length / 4];
            int width = preview.Image.Width;

            for (int y = 0; y < preview.Image.Height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int index = (y * width) + x;
                    int flippedIndex = ((preview.Image.Height - y - 1) * width) + x;

                    byte r = preview.Image.Data[flippedIndex * 4];
                    byte g = preview.Image.Data[flippedIndex * 4 + 1];
                    byte b = preview.Image.Data[flippedIndex * 4 + 2];
                    byte a = preview.Image.Data[flippedIndex * 4 + 3];

                    colors[index] = new Color32(r, g, b, a);
                }
            }

            uTexture.SetPixels32(colors);
            uTexture.Apply();
            uTexture.Scale(512, 512, true);

            var meshList = new List<(string Path, ResourceStream)>()
            {
                (targetRend.MeshPath, new ResourceStream(new MemoryStream(File.ReadAllBytes(targetRend.MeshPath))))
            };
            var sprite = Sprite.Create(uTexture, Rect.MinMaxRect(0, 0, uTexture.width, uTexture.height), new Vector2(uTexture.width / 2, uTexture.height / 2));

            instance.SetGUID(guid);
            instance.SetScaleOffset(new Vector3(0.25f,0.25f,0.25f));
            instance.SetMesh(meshList);
            instance.SetTextures(TextureStreams.ToDict());
            instance.SetCustomTextures(customTextureData);

            instance.description = Description;
            instance.displayName = DisplayName;
            instance.keywords = "tmp";
            instance.name = part.Name ?? part.UUID;

            instance.advanced = false;
            instance.affectedByProjectileExplosion = true;
            instance.agent = typeof(GameClass.Agent);
            instance.canBeModule = true;
            instance.componentAllowNonUniformScale = false;
            instance.componentAllowsDocking = false;
            instance.componentAllowsMounting = false;
            instance.componentCanHaveFocus = false;
            instance.componentCategory = ComponentCategories.All;
            instance.componentConsumesInput = false;
            instance.componentDisableScaling = false;
            instance.componentFocusLocksCamera = false;
            instance.componentHidden = false;
            instance.componentHidesHintsUnderRaycast = false;
            instance.componentIcon = sprite;
            instance.componentIds = new Dictionary<int, string>() { { 0, "Bush" } };
            instance.componentInteractionLocksCamera = false;
            instance.componentInteractive = false;
            instance.componentMass = 0.5f;
            instance.componentPlasmaConsumption = 1f;
            instance.componentPlasmaInteraction = true;
            instance.componentPrefab = ComponentManager.GetNewAgentPrefab(instance.Guid);
            instance.componentPreview = sprite;
            instance.componentReactsToRaycast = true;
            instance.componentReactsToScaling = true;
            instance.componentScaleXLimits = new PLibrary.FloatRange(0.01f, 1000f);
            instance.componentScaleYLimits = new PLibrary.FloatRange(0.01f, 1000f);
            instance.componentScaleZLimits = new PLibrary.FloatRange(0.01f, 1000f);
            instance.componentSupportSecondarySnappingPointChild = true;
            instance.componentSuppressTerrainImpactSFX = false;
            instance.componentVolumeControl = false;
            instance.defaultMassCategory = MassCategories.Light;
            instance.defaultsToKinematic = false;
            instance.developersOnly = false;
            instance.deviceComponentModifier = null;
            instance.SetDriver(typeof(DynamicDriver));
            instance.experimental = true;
            instance.handlesModuleProperties = false;
            instance.hideNode = true;
            /// NEVER change instance value, once you've shared the mod
            instance.id = CategoryManager.CreateGestaltEnum(instance.Guid);
            instance.modifierAffectsAllBodies = false;
            instance.needsResources = false;
            instance.nodeAlwaysRun = false;
            instance.nodeCategory = PLibrary.AgentCategoryEnum.Misc;
            instance.nodeManualGestaltId = PLibrary.NodeManualGestaltEnum.MathExpression;
            instance.nodeRepeatable = false;
            instance.nusDefinitions = null;
            instance.ports = new Dictionary<int, Port>();
            instance.processesModuleInterfaces = false;
            instance.properties = new Dictionary<int, Property>();
            instance.simulatedPhysicsWhenMounted = false;
            instance.spawnScale = Vector3.one;
            instance.type = GameClass.AgentGestalt.Types.Component;

            return true;
        }

        public static void SaveImageToWorkingDirectory(ImageResult image, string fileName)
        {
            var outputPath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            using Bitmap bitmap = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb);
            var bitmapData = bitmap.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.WriteOnly, bitmap.PixelFormat);
            System.Runtime.InteropServices.Marshal.Copy(image.Data, 0, bitmapData.Scan0, image.Data.Length);
            bitmap.UnlockBits(bitmapData);
            bitmap.Save(outputPath, ImageFormat.Png);
        }

        private static string GetGameDir()
        {
            var paths = new List<string>()
            {
                (string)Registry.LocalMachine?.OpenSubKey("SOFTWARE\\WOW6432Node\\Valve\\Steam")?.GetValue("InstallPath")
            };
            if (paths[0] == null || !Directory.Exists(paths[0])) return null;

            string config = File.ReadAllText($"{paths[0]}\\config\\config.vdf");
            foreach (Match match in Regex.Matches(config, "\"BaseInstallFolder_[0-9]\"\\s+\"([^\"]+)\""))
                paths.Add(match.Groups[1].Value.Replace("\\\\", "\\"));

            string startVDF = File.ReadAllText($"{paths[0]}\\steamapps\\libraryfolders.vdf");
            foreach (Match match in Regex.Matches(startVDF, "\"path\"\\s+\"([^\"]+)\""))
                paths.Add(match.Groups[1].Value.Replace("\\\\", "\\"));

            foreach (string path in paths)
            {
                string assembliesPath = $"{path}\\steamapps\\common\\Scrap Mechanic";
                if (Directory.Exists(assembliesPath)) return assembliesPath;
            }
            return null;
        }
    }
}
