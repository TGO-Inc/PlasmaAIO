//using PlasmaDevToolkit.Overrides;
using ImageProcessor;
using System.Collections;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Media.Imaging;
using UnityEngine;
using UnityEngine.Networking;

namespace PlasmaAPI.Packs.ImportModel
{
    /// <summary>
    /// Filesystem implementation that uses the standard .NET File class.
    /// </summary>
    internal class FileFilesystem : IFilesystem
    {
        public byte[] ReadAllBytes(string path)
        {
            return File.ReadAllBytes(path);
        }

        public string[] ReadAllLines(string path)
        {
            return File.ReadAllLines(path);
        }

        public FileStream OpenRead(string path)
        {
            return File.OpenRead(path);
        }

        public IEnumerator DownloadUri(string uri, bool notifyErrors, Assembly asm)
        {

            var resourceName = string.Empty;

            foreach (var assemblyName in asm.GetManifestResourceNames())
            {
                if (assemblyName.EndsWith(uri))
                {
                    resourceName = assemblyName;
                }
            }
            using (var stream = asm.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                yield return reader.ReadToEnd();
            }

            /*
//#if UNITY_2018_3_OR_NEWER
            UnityWebRequest uwr = UnityWebRequest.Get(uri);
            yield return uwr.SendWebRequest();

//#if UNITY_2020_2_OR_NEWER
            if (uwr.result == UnityWebRequest.Result.ConnectionError)
//#else
            //if (uwr.isNetworkError || uwr.isHttpError)
//#endif
            {
                if (notifyErrors)
                {
                    Debug.LogWarning(uwr.error, LogType.Error);
                }

                yield return null;
            }
            else
            {
                // Get downloaded asset bundle
                yield return uwr.downloadHandler.text;
            }
//#else
/*
            WWW www = new WWW(uri);
            yield return www;
            if (www.error != null)
            {
                if (notifyErrors)
                {
                    Debug.LogError("Error loading " + uri + "\n" + www.error);
                }

                yield return null;
            }
            else
            {
                yield return www.text;
            }
            
#endif*/
        }

        public IEnumerator DownloadTexture(string uri, Assembly asm)
        {
#if UNITY_2018_3_OR_NEWER
            using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture(uri))
            {
                yield return uwr.SendWebRequest();

//#if UNITY_2020_2_OR_NEWER
                if (uwr.result == UnityWebRequest.Result.ConnectionError)
//#else
                //if (uwr.isNetworkError || uwr.isHttpError)
//#endif
                {
                    Debug.LogError(uwr.error);
                    yield return null;
                }
                else
                {
                    // Get downloaded asset bundle
                    yield return DownloadHandlerTexture.GetContent(uwr);
                }
            }
            /*
#else
            yield return LoadTexture(uri, asm);
#endif
        }

#if !UNITY_2018_3_OR_NEWER
        /// <summary>
        /// Load a texture from the URL got from the parameter.
        /// </summary>
        private Texture2D LoadTexture(string path, Assembly asm)
        {
            Texture2D tex = null;
            
            using var stream = asm.GetManifestResourceStream(asm.GetManifestResourceNames().Where(m => m.EndsWith(path)).FirstOrDefault());
            using var reader = new BinaryReader(stream);
            var img = new ImageFactory()
                .Load(stream)
                .AutoRotate();

            tex = new Texture2D(img.Image.Width, img.Image.Height);
            tex.LoadImage(reader.ReadBytes(int.MaxValue));

            return tex;
        }
#endif
    }
}