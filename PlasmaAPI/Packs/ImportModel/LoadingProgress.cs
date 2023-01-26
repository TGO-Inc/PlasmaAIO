//using PlasmaDevToolkit.Overrides;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.Packs.ImportModel
{
    /// <summary>
    /// Loading progress information for a single OBJ loader
    /// </summary>
    internal class SingleLoadingProgress
    {
        public string fileName;
        private string msg;
        public string message
        {
            get { return msg; }
            set
            {
                Debug.LogWarning(value);
                msg = value;
            }
        }
        public float percentage = 0;
        // TODO: split percentages, e.g.: public float parsingPercentage = 0;
        public int numObjects = 0;
        public int numSubObjects = 0;
        public bool error = false;
    }

    /// <summary>
    /// Overall loading progress for all the active OBJ loaders (list of SingleLoadingProgress).
    /// See <see cref="SingleLoadingProgress"/>.
    /// </summary>
    internal class LoadingProgress
    {
        public List<SingleLoadingProgress> singleProgress = new List<SingleLoadingProgress>();
    }
}
