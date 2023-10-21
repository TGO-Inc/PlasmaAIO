using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;  // Ensure you have Newtonsoft.Json added via NuGet

namespace Plasma.Mods.ScrapMechanicMod
{
    public static class DirectoryProcessor
    {
        public static List<FileInfo> FindAllDatabaseFiles(string parent_dir)
        {
            var jsonFiles = new List<FileInfo>();

            var dirInfo = new DirectoryInfo(parent_dir);
            if (!dirInfo.Exists)
            {
                throw new DirectoryNotFoundException("The provided parent directory does not exist.");
            }

            // Recursively searching for directories ending with "Objects\Database"
            foreach (var dir in dirInfo.GetDirectories("Database", SearchOption.AllDirectories))
            {
                if (dir.Parent?.Name == "Objects")
                {
                    jsonFiles.AddRange(dir.GetFiles("*.json"));
                }
            }

            var realWorldPaths = new List<FileInfo>();
            var refList = new List<string>();

            foreach (var jsonFile in jsonFiles)
            {
                var jsonData = File.ReadAllText(jsonFile.FullName);
                var jsonObject = JObject.Parse(jsonData);

                // Check if "shapeSetList" exists in the JSON
                var partList = jsonObject["shapeSetList"];
                if (partList != null)
                {
                    foreach (var part in partList)
                    {
                        var path = (string)part;
                        if (!string.IsNullOrEmpty(path) && !refList.Contains(path))
                        {
                            refList.Add(path);
                            // Adjusting the path to its real-world equivalent
                            path = DataProcessor.CorrectPath(path, parent_dir);
                            realWorldPaths.Add(new FileInfo(path));
                        }
                    }
                }
            }

            return realWorldPaths;
        }
    }
}
