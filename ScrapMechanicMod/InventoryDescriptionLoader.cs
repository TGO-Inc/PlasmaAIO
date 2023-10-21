using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Plasma.Mods.ScrapMechanicMod
{
    public class InventoryDescriptionLoader
    {
        public static Dictionary<string, (string Name, string Description)> LoadDescriptions(string parentDir)
        {
            var result = new Dictionary<string, (string Name, string Description)>();

            // Search for all InventoryItemDescriptions.json files under "English" folders.
            var files = Directory.GetFiles(parentDir, "InventoryItemDescriptions.json", SearchOption.AllDirectories)
                                 .Where(path => path.Contains(Path.DirectorySeparatorChar + "English" + Path.DirectorySeparatorChar))
                                 .ToList();

            foreach (var file in files)
            {
                var content = File.ReadAllText(file);
                var json = JObject.Parse(content);

                foreach (var item in json)
                {
                    var uuid = item.Key.ToUpperInvariant();
                    var name = item.Value["title"].ToString();
                    var description = item.Value["description"]?.ToString();

                    if (!result.ContainsKey(uuid))
                        result.Add(uuid, (name, description));
                }
            }

            return result;
        }
    }
}
