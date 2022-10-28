using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using PlasmaDevToolkit.Overrides;
//using Console = PlasmaDevToolkit.Overrides.Console;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace PlasmaAPI.Packs.Model
{
    /// <summary>
    /// Component that imports objects from a model, both at run-rime and as assets in Editor.
    /// </summary>
    /// <remarks></remarks>
    internal class ObjectImporter : MonoBehaviour
    {
        protected int numTotalImports = 0;
        protected bool allLoaded = false;
        protected ImportOptions buildOptions = null;
        protected List<Loader> loaderList = new List<Loader>();
        private ImportPhase importPhase = ImportPhase.Idle;

        /// <summary>
        /// Event triggered when starting to import.
        /// </summary>
        public event Action ImportingStart;

        /// <summary>
        /// Event triggered when finished importing.
        /// </summary>
        public event Action ImportingComplete;

        /// <summary>
        /// Event triggered when a single model has been created and before it is imported.
        /// </summary>
        public event Action<GameObject, string> CreatedModel;

        /// <summary>
        /// Event triggered when a single model has been successfully imported.
        /// </summary>
        public event Action<GameObject, string> ImportedModel;

        /// <summary>
        /// Event triggered when an error occurred importing a model.
        /// </summary>
        public event Action<string> ImportError;

        private enum ImportPhase { Idle, TextureImport, ObjLoad, AssetBuild, Done }


        /// <summary>
        /// Number of pending import activities.
        /// </summary>
        public int NumImportRequests
        {
            get { return numTotalImports; }
        }

        /// <summary>
        /// Create the proper loader component according to the file extension.
        /// </summary>
        /// <param name="absolutePath">path of the model to be imported</param>
        /// <returns>A proper loader or null if not available.</returns>
        private Loader CreateLoader(string absolutePath)
        {
            string ext = Path.GetExtension(absolutePath);
            if (string.IsNullOrEmpty(ext))
            {
                //Console.FormatMessage("No extension defined, unable to detect file format", LogType.Error);
                return null;
            }
            Loader loader = null;
            ext = ext.ToLower();
            if (ext.StartsWith(".php"))
            {
                if (!ext.EndsWith(".obj"))
                {
                    // TODO: other formats supported? Remark: often there are zip and rar archives without extension.
                    //Console.FormatMessage("Unable to detect file format in " + ext, LogType.Error);
                    return null;
                }
                loader = gameObject.AddComponent<LoaderObj>();
            }
            else
            {
                switch (ext)
                {
                    case ".obj":
                        loader = gameObject.AddComponent<LoaderObj>();
                        break;
                    // TODO: add mode formats here...
                    default:
                        //Console.FormatMessage($"File format not supported ({ext})", LogType.Error);
                        return null;
                }
            }
            loader.ModelCreated += OnModelCreated;
            loader.ModelLoaded += OnImported;
            loader.ModelError += OnImportError;

            return loader;
        }


        /// <summary>
        /// Request to load a file asynchronously.
        /// </summary>
        /// <param name="objName"></param>
        /// <param name="filePath"></param>
        /// <param name="parentObj"></param>
        /// <param name="options"></param>
        public void ImportModelAsync(string objName, string filePath, Transform parentObj, ImportOptions options)
        {
            if (loaderList == null)
            {
                loaderList = new List<Loader>();
            }
            if (loaderList.Count == 0)
            {
                numTotalImports = 0;// files.Length;
                if (ImportingStart != null)
                {
                    ImportingStart();
                }
            }
            // If the given path is a URI leave it as it is, else get its absolute path
            string absolutePath = filePath.Contains("//") ? filePath : Path.GetFullPath(filePath);
            Loader loader = CreateLoader(absolutePath);
            if (loader == null)
            {
                return;
            }
            numTotalImports++;
            loaderList.Add(loader);
            loader.buildOptions = options;
            if (string.IsNullOrEmpty(objName))
            {
                objName = Path.GetFileNameWithoutExtension(absolutePath);
            }
            allLoaded = false;
            StartCoroutine(loader.Load(objName, absolutePath, parentObj));
        }


        /// <summary>
        /// Update the loading/importing status
        /// </summary>
        public virtual void UpdateStatus()
        {
            if (allLoaded) return;
            int num_loaded_files = numTotalImports - Loader.totalProgress.singleProgress.Count;

            bool loading = num_loaded_files < numTotalImports;
            if (!loading)
            {
                allLoaded = true;
                if (loaderList != null)
                {
                    foreach (var loader in loaderList)
                    {
                        Destroy(loader);
                    }
                    loaderList.Clear();
                }
                OnImportingComplete();
            }
        }


        protected virtual void Update()
        {
            UpdateStatus();
        }


        /// <summary>
        /// Called when finished importing. It triggers ImportingComplete event, if it was set.
        /// </summary>
        protected virtual void OnImportingComplete()
        {
            if (ImportingComplete != null)
            {
                ImportingComplete();
            }
        }


        /// <summary>
        /// Called when each model has been created and before it is imported. It triggers CreatedModel event, if it was set.
        /// </summary>
        protected virtual void OnModelCreated(GameObject obj, string absolutePath)
        {
            if (CreatedModel != null)
            {
                CreatedModel(obj, absolutePath);
            }
        }


        /// <summary>
        /// Called when each model has been imported. It triggers ImportedModel event, if it was set.
        /// </summary>
        protected virtual void OnImported(GameObject obj, string absolutePath)
        {
            if (ImportedModel != null)
            {
                ImportedModel(obj, absolutePath);
            }
        }


        /// <summary>
        /// Called when a model import fails. It triggers ImportError event, if it was set.
        /// </summary>
        protected virtual void OnImportError(string absolutePath)
        {
            if (ImportError != null)
            {
                ImportError(absolutePath);
            }
        }

    }
}
