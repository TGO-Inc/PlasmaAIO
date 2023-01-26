extern alias GameClass;
using GameClass;
using PlasmaAPI.Packs.ImportModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PlasmaAPI.API
{
    public class ObjImporter
    {
        static ObjectImporter importer;
        static readonly GameObject goImporter = new GameObject("ObjectImporter");
        public static void ImportModel(MonoBehaviour parent, string path, Assembly asm, Action<GameObject, string> Callback)
        {
            if (goImporter.GetComponents(typeof(ObjectImporter)).Length == 0)
                importer = goImporter.AddComponent<ObjectImporter>();

            importer.CreatedModel += Callback;
            string name = System.IO.Path.GetFileName(path);
            importer.ImportModelAsync(name, path, parent.transform, new ImportOptions()
            {
                buildColliders = true,
                modelScaling = 0.001f,
                localPosition = new Vector3(0, 0, 0),
            }, asm);
        }
        public static void ImportModel(string path, Assembly asm, Action<GameObject, string> Callback)
        {
            if (goImporter.GetComponents(typeof(ObjectImporter)).Length == 0)
                importer = goImporter.AddComponent<ObjectImporter>();

            importer.CreatedModel += Callback;
            string name = Path.GetFileName(path);
            importer.ImportModelAsync(name, path, null, new ImportOptions()
            {
                buildColliders = true,
                modelScaling = 0.001f,
                hideWhileLoading = true,
                reuseLoaded = true,
                localPosition = new Vector3(0, 0, 0),
            }, asm);
        }
        public static void ImportModel(string path, Assembly asm, AgentGestalt agent)
        {
            if (goImporter.GetComponents<ObjectImporter>().Length == 0)
                importer = goImporter.AddComponent<ObjectImporter>();

            importer.ImportError += Importer_ImportError;
            importer.CreatedModel += (GameObject obj, string path) =>
            {
                var comphdnlr = agent.componentPrefab.GetComponent<ComponentHandler>();
                var sub = comphdnlr.gameObject.GetComponentsInChildren<SubComponentHandler>().FirstOrDefault();
                var list = sub.GetComponentsInChildren<MeshFilter>();
                list.FirstOrDefault().mesh = obj.GetComponent<ModelReferences>().meshReferences[0];
                File.WriteAllLines("logxtg.log", list.Select(i => i.ToString()));
            };

            string name = Path.GetFileName(path);

            Debug.LogWarning(name);

            importer.ImportModelAsync(name, path, null, new ImportOptions()
            {
                buildColliders = true,
                modelScaling = 0.001f,
                hideWhileLoading = true,
                reuseLoaded = true,
                localPosition = new Vector3(0, 0, 0),
            }, asm);
        }

        private static void Importer_ImportError(string obj)
        {
            File.WriteAllText("import.log", obj);
        }
    }
}
