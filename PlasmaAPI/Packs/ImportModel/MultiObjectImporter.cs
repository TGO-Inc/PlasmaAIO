﻿//using PlasmaDevToolkit.Overrides;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace PlasmaAPI.Packs.ImportModel
{
    /// <summary>
    /// Load the objects in the given list with their parameters and positions.
    /// </summary>
    internal class MultiObjectImporter : ObjectImporter
    {
        [Tooltip("Load models in the list on start")]
        public bool autoLoadOnStart = false;

        [Tooltip("Models to load on startup")]
        public List<ModelImportInfo> objectsList = new List<ModelImportInfo>();

        [Tooltip("Default import options")]
        public ImportOptions defaultImportOptions = new ImportOptions();

        [SerializeField]
        private PathSettings pathSettings = null;

        public string RootPath
        {
            get
            {
                return pathSettings != null ? pathSettings.RootPath : "";
            }
        }

        /// <summary>
        /// Load a set of files with their own import options
        /// </summary>
        /// <param name="modelsInfo">List of file import entries</param>
        public void ImportModelListAsync(ModelImportInfo[] modelsInfo, Assembly asm)
        {
            if (modelsInfo == null)
            {
                return;
            }
            for (int i = 0; i < modelsInfo.Length; i++)
            {
                if (modelsInfo[i].skip) continue;
                string objName = modelsInfo[i].name;
                string filePath = modelsInfo[i].path;
                if (string.IsNullOrEmpty(filePath))
                {
                    Debug.LogWarning($"File path missing for the model at position {i} in the list.");
                    continue;
                }

                filePath = RootPath + filePath;

                ImportOptions options = modelsInfo[i].loaderOptions;
                if (options == null || options.modelScaling == 0)
                {
                    options = defaultImportOptions;
                }
                ImportModelAsync(objName, filePath, transform, options, asm);
            }
        }
    }
}
