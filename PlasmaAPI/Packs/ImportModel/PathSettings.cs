using System.IO;
using UnityEngine;

namespace PlasmaAPI.Packs.ImportModel
{
    internal enum RootPathEnum
    {
        Url,
        DataPath,
        DataPathParent,
        PersistentDataPath,
        StreamingAssetsPath,
        CurrentPath
    }


    internal class PathSettings : MonoBehaviour
    {
        [Tooltip("Default root path for models")]
        public RootPathEnum defaultRootPath = RootPathEnum.Url;

        [Tooltip("Root path for models on mobile devices")]
        public RootPathEnum mobileRootPath = RootPathEnum.Url;


        public string RootPath
        {
            get
            {
                switch (defaultRootPath)
                {
                    case RootPathEnum.DataPath:
                        return UnityEngine.Application.dataPath + "/";
                    case RootPathEnum.DataPathParent:
                        return UnityEngine.Application.dataPath + "/../";
                    case RootPathEnum.PersistentDataPath:
                        return UnityEngine.Application.persistentDataPath + "/";
                    case RootPathEnum.StreamingAssetsPath:
                        return UnityEngine.Application.streamingAssetsPath + "/";
                }
                return "";
            }
        }


        public static PathSettings FindPathComponent(GameObject obj)
        {
            PathSettings pathSettings = obj.GetComponent<PathSettings>();
            if (pathSettings == null)
            {
                pathSettings = FindObjectOfType<PathSettings>();
            }
            if (pathSettings == null)
            {
                pathSettings = obj.AddComponent<PathSettings>();
            }
            return pathSettings;
        }


        public string FullPath(string path)
        {
            string fullPath = path;
            if(!Path.IsPathRooted(path))
            {
                fullPath = RootPath + path;
            }
            return fullPath;
        }
    
    }
}
