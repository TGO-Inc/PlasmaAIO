using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NodeCanvas.Tasks.Actions;

namespace Plasma.Mods.ScrapMechanicMod
{
    public static class DataProcessor
    {
        public class PartData
        {
            public string UUID { get; set; }
            public string Name { get; set; }
            public string DisplayName { get; set; }
            public string Color { get; set; }
            public List<RendProcessor.RendData> Renderable { get; set; }
            public CollisionData Collision { get; set; }
        }

        public class CollisionData
        {
            public string Type { get; set; } // hull, sphere, box, etc.
            public JObject Data { get; set; } // The associated data for the collision type
        }

        public static List<PartData> ProcessPartListFiles(List<FileInfo> jsonFiles, string parent_dir)
        {
            var extractedData = new List<PartData>();

            foreach (var file in jsonFiles)
            {
                var jsonData = File.ReadAllText(file.FullName);
                var jsonObject = JObject.Parse(jsonData);

                if (jsonObject["partList"] is JArray partList)
                {
                    foreach (var part in partList)
                    {
                        //Console.WriteLine(part["uuid"].ToString());
                        var partData = new PartData
                        {
                            UUID = part["uuid"].ToString(),
                            Name = part["name"]?.ToString(),
                            Color = part["color"]?.ToString(),
                            Renderable = DataProcessor.GetRenderable(part["renderable"], parent_dir),
                            Collision = DataProcessor.GetCollision(part)
                        };

                        extractedData.Add(partData);
                    }
                }
            }

            return extractedData;
        }
        private static List<RendProcessor.RendData> GetRenderable(JToken renderableToken, string parent_dir)
        {
            //Console.WriteLine(renderableToken.Type);

            if (renderableToken.Type == JTokenType.String)
            {
                string path = DataProcessor.CorrectPath(renderableToken.ToString(), parent_dir);
                return RendProcessor.ExtractRendData(File.ReadAllText(path), parent_dir);
            }

            // If it's not a string, we assume it's a JObject
            return RendProcessor.ExtractRendData(renderableToken as JObject, parent_dir);
        }
        private static CollisionData GetCollision(JToken part)
        {
            var collisionData = new CollisionData();

            // Identify the collision type
            string[] possibleCollisionTypes = { "cylinder", "sphere", "hull", "box" };
            foreach (var collisionType in possibleCollisionTypes)
            {
                var collisionInfo = part[collisionType];
                if (collisionInfo != null)
                {
                    collisionData.Type = collisionType;
                    collisionData.Data = collisionInfo as JObject;
                    break;
                }
            }

            return collisionData;
        }
        public static string NormalizePath(string path)
        {
            return Path.GetFullPath(new Uri(path).LocalPath)
                       .TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)
                       .ToUpperInvariant();
        }
        public static string CorrectPath(string path, string parent_dir)
        {
            if (string.IsNullOrEmpty(path)) return path;

            // Replace with your actual paths
            if (path.Contains("$CHALLENGE_DATA"))
                path = NormalizePath(path.Replace("$CHALLENGE_DATA", Path.Combine(parent_dir, "ChallengeData")));
            if (path.Contains("$GAME_DATA"))
                path = NormalizePath(path.Replace("$GAME_DATA", Path.Combine(parent_dir, "Data")));
            if (path.Contains("$SURVIVAL_DATA"))
                path = NormalizePath(path.Replace("$SURVIVAL_DATA", Path.Combine(parent_dir, "Survival")));

            return path;
        }
    }
}
