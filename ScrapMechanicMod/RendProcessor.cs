using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plasma.Mods.ScrapMechanicMod
{
    public class RendProcessor
    {
        public class RendData
        {
            public string MeshPath { get; set; }
            public string MaterialType { get; set; }
            public List<string> TexturePaths { get; set; } = new List<string>();
        }
        public static List<RendData> ExtractRendData(string jsonContent, string parent_dir)
            => ExtractRendData(JObject.Parse(jsonContent), parent_dir);
        public static List<RendData> ExtractRendData(JObject jsonObject, string parent_dir)
        {
            var rendDataList = new List<RendData>();

            //var jsonObject = JObject.Parse(jsonContent);

            if (!(jsonObject["lodList"] is JArray lodList)) return rendDataList;

            foreach (var lod in lodList)
            {
                var rendData = new RendData
                {
                    // Extracting MeshPath
                    MeshPath = DataProcessor.CorrectPath(lod["mesh"]?.ToString(), parent_dir)
                };

                // Extracting MaterialType and TexturePaths
                if (lod["subMeshMap"] is JObject subMeshMap)
                {
                    foreach (var subMeshEntry in subMeshMap)
                    {
                        var materialType = subMeshEntry.Value["material"]?.ToString();
                        if (string.IsNullOrEmpty(rendData.MaterialType))
                        {
                            rendData.MaterialType = materialType;
                        }

                        if (subMeshEntry.Value["textureList"] is JArray jary)
                        {
                            foreach (var texture in jary)
                            {
                                string tex = DataProcessor.CorrectPath(texture.ToString(), parent_dir);
                                if (!rendData.TexturePaths.Contains(tex))
                                    rendData.TexturePaths.Add(tex);
                            }
                        }
                    }
                }
                else if (lod["subMeshList"] is JArray subMeshList)
                {
                    foreach (var subMeshEntry in subMeshList)
                    {
                        var materialType = subMeshEntry["material"]?.ToString();
                        if (string.IsNullOrEmpty(rendData.MaterialType))
                        {
                            rendData.MaterialType = materialType;
                        }

                        if (subMeshEntry["textureList"] is JArray jary)
                        {
                            foreach (var texture in jary)
                            {
                                string tex = DataProcessor.CorrectPath(texture.ToString(), parent_dir);
                                if (!rendData.TexturePaths.Contains(tex))
                                    rendData.TexturePaths.Add(tex);
                            }
                        }
                    }
                }

                rendDataList.Add(rendData);
            }

            return rendDataList;
        }
    }
}
