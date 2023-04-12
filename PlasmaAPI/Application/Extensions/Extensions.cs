using Assimp.Unmanaged;
using MonoMod.Utils;
using Newtonsoft.Json;
using PlasmaAPI.API.Patches;
using PlasmaAPI.Application.InternalClass;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace PlasmaAPI.Application.Extensions
{
    public static class Extensions
    {
        internal static void Add(this ConcurrentDictionary<string, AssemblyContainer> dictionary, string name, AssemblyContainer assembly)
        {
            dictionary.TryAdd(name, assembly);
        }
        public static bool ContainsValue(this ConcurrentDictionary<Guid, Delegate> dictionary, Delegate d, out Guid id)
        {
            foreach (var i in dictionary)
            {
                if (i.Value.Equals(d))
                {
                    id = i.Key;
                    return true;
                }
            }
            id = Guid.Empty;
            return false;
        }
        public static T Clone<T>(this T obj)
        {
            var inst = obj.GetType().GetMethod("MemberwiseClone", BindingFlags.Instance | BindingFlags.NonPublic);

            return (T)inst?.Invoke(obj, null);
        }
        public static string ToJson<T>(this T obj)
        {
            var settings = new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore };
            return JsonConvert.SerializeObject(obj, Formatting.Indented, settings);
        }
        internal static void Deconstruct<T>(this IList<T> list, out GenericObject<T> first, out IList<T> rest)
        {
            first = list.Count > 0 ? list[0] : default; // or throw
            rest = list.Skip(1).ToList();
        }

        internal static void Deconstruct<T>(this IList<T> list, out GenericObject<T> first, out GenericObject<T> second, out IList<T> rest)
        {
            first = list.Count > 0 ? list[0] : default; // or throw
            second = list.Count > 1 ? list[1] : default; // or throw
            rest = list.Skip(2).ToList();
        }

        public static Dictionary<T, H> ExpandRange<T, H>(this Dictionary<T, H> first, Dictionary<T, H> second)
        {
            var tmp = new Dictionary<T, H>(first);
            tmp.AddRange(second);
            return tmp;
        }
        public static Dictionary<T, H> Expand<T, H>(this Dictionary<T, H> first, T k, H v)
        {
            var tmp = new Dictionary<T, H>(first)
            {
                { k, v }
            };
            return tmp;
        }
        public static void MapValues<TSource, TDestination>(TSource source, TDestination destination)
        {
            PropertyInfo[] properties = typeof(TSource).GetProperties(BindingFlags.Instance);

            foreach (PropertyInfo property in properties)
            {
                if (property.CanWrite)
                {
                    object value = property.GetValue(source, null);
                    property.SetValue(destination, value, null);
                }
            }
        }

        public static Dictionary<string, ResourceStream> ToDict(this IEnumerable<(string, ResourceStream)> t)
        {
            Dictionary<string, ResourceStream> keyValuePairs = new Dictionary<string, ResourceStream>();
            foreach (var (Key, Value) in t) keyValuePairs.Add(Key, Value);
            return keyValuePairs;
        }
        
        public static IEnumerable<ResourceStream> ToEnum(this IEnumerable<(string, ResourceStream)> t)
        {
            foreach (var (_, Value) in t)
                yield return Value;
        }

        public static void Scale(this Texture2D texture2D, double targetX, double targetY, bool keepAspectRatio = false)
        {
            double AspectRatioX = 1;
            double AspectRatioY = 1;
            if (keepAspectRatio)
            {
                AspectRatioX = Math.Min(texture2D.width / (double)texture2D.height, 1);
                AspectRatioY = Math.Min(texture2D.height / (double)texture2D.width, 1);
            }
            TextureScale.Bilinear(texture2D, (int)(targetX * AspectRatioX), (int)(targetY * AspectRatioY));
        }
    }
    internal class TextureScale
    {
        public class ThreadData
        {
            public int start;
            public int end;
            public ThreadData(int s, int e)
            {
                start = s;
                end = e;
            }
        }

        private static Color[] texColors;
        private static Color[] newColors;
        private static int w;
        private static float ratioX;
        private static float ratioY;
        private static int w2;
        private static int finishCount;
        private static Mutex mutex;

        public static void Point(Texture2D tex, int newWidth, int newHeight)
        {
            ThreadedScale(tex, newWidth, newHeight, false);
        }

        public static void Bilinear(Texture2D tex, int newWidth, int newHeight)
        {
            ThreadedScale(tex, newWidth, newHeight, true);
        }

        private static void ThreadedScale(Texture2D tex, int newWidth, int newHeight, bool useBilinear)
        {
            texColors = tex.GetPixels();
            newColors = new Color[newWidth * newHeight];
            if (useBilinear)
            {
                ratioX = 1.0f / ((float)newWidth / (tex.width - 1));
                ratioY = 1.0f / ((float)newHeight / (tex.height - 1));
            }
            else
            {
                ratioX = ((float)tex.width) / newWidth;
                ratioY = ((float)tex.height) / newHeight;
            }
            w = tex.width;
            w2 = newWidth;
            var cores = Mathf.Min(SystemInfo.processorCount, newHeight);
            var slice = newHeight / cores;

            finishCount = 0;
            if (mutex == null)
            {
                mutex = new Mutex(false);
            }
            if (cores > 1)
            {
                int i = 0;
                ThreadData threadData;
                for (i = 0; i < cores - 1; i++)
                {
                    threadData = new ThreadData(slice * i, slice * (i + 1));
                    ParameterizedThreadStart ts = useBilinear ? new ParameterizedThreadStart(BilinearScale) : new ParameterizedThreadStart(PointScale);
                    Thread thread = new Thread(ts);
                    thread.Start(threadData);
                }
                threadData = new ThreadData(slice * i, newHeight);
                if (useBilinear)
                {
                    BilinearScale(threadData);
                }
                else
                {
                    PointScale(threadData);
                }
                while (finishCount < cores)
                {
                    Thread.Sleep(1);
                }
            }
            else
            {
                ThreadData threadData = new ThreadData(0, newHeight);
                if (useBilinear)
                {
                    BilinearScale(threadData);
                }
                else
                {
                    PointScale(threadData);
                }
            }

            tex.Reinitialize(newWidth, newHeight);
            tex.SetPixels(newColors);
            tex.Apply();

            texColors = null;
            newColors = null;
        }

        public static void BilinearScale(System.Object obj)
        {
            ThreadData threadData = (ThreadData)obj;
            for (var y = threadData.start; y < threadData.end; y++)
            {
                int yFloor = (int)Mathf.Floor(y * ratioY);
                var y1 = yFloor * w;
                var y2 = (yFloor + 1) * w;
                var yw = y * w2;

                for (var x = 0; x < w2; x++)
                {
                    int xFloor = (int)Mathf.Floor(x * ratioX);
                    var xLerp = x * ratioX - xFloor;
                    newColors[yw + x] = ColorLerpUnclamped(ColorLerpUnclamped(texColors[y1 + xFloor], texColors[y1 + xFloor + 1], xLerp),
                                                           ColorLerpUnclamped(texColors[y2 + xFloor], texColors[y2 + xFloor + 1], xLerp),
                                                           y * ratioY - yFloor);
                }
            }

            mutex.WaitOne();
            finishCount++;
            mutex.ReleaseMutex();
        }

        public static void PointScale(System.Object obj)
        {
            ThreadData threadData = (ThreadData)obj;
            for (var y = threadData.start; y < threadData.end; y++)
            {
                var thisY = (int)(ratioY * y) * w;
                var yw = y * w2;
                for (var x = 0; x < w2; x++)
                {
                    newColors[yw + x] = texColors[(int)(thisY + ratioX * x)];
                }
            }

            mutex.WaitOne();
            finishCount++;
            mutex.ReleaseMutex();
        }

        private static Color ColorLerpUnclamped(Color c1, Color c2, float value)
        {
            return new Color(c1.r + (c2.r - c1.r) * value,
                              c1.g + (c2.g - c1.g) * value,
                              c1.b + (c2.b - c1.b) * value,
                              c1.a + (c2.a - c1.a) * value);
        }
    }
}
