using PlasmaAPI.GameClass.Visor;
using PlasmaAPI.Packs.ImportModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PlasmaAPI.API
{
    public class ObjImporter
    {
        static ObjectImporter importer;
        static readonly GameObject goImporter = new GameObject("ObjectImporter");
        public static void ImportModel(string path)
        {
            if (goImporter.GetComponents(typeof(ObjectImporter)).Length == 0)
                importer = goImporter.AddComponent<ObjectImporter>();
            
            importer.CreatedModel += Importer_CreatedModel;
            string name = System.IO.Path.GetFileName(path);
            importer.ImportModelAsync(name, path, null, new ImportOptions()
            {
                buildColliders = true,
                modelScaling = 0.001f,
                localPosition = new Vector3(0, 3, 0),
            });
        }

        private static void Importer_CreatedModel(GameObject arg1, string arg2)
        {
            arg1.isStatic = false;
        }
    }
}
