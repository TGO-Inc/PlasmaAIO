using AsImpL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using PlasmaDevToolkit.Overrides;
using Console = PlasmaDevToolkit.Overrides.Console;

namespace PlasmaDevToolkit.ModLoader.API
{
    internal class ObjImporter
    {
        static ObjectImporter importer;
        static GameObject gameObject;
        public static void ImportModel(string path)
        {
            gameObject = new GameObject("Created GameObject");
            importer = gameObject.AddComponent<ObjectImporter>();
            importer.ImportModelAsync("TestObject", path, null, new ImportOptions() { buildColliders = true, modelScaling = 0.01f }); ;
        }
    }
}
