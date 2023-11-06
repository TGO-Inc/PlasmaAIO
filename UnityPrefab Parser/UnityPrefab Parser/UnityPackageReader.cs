using PrefabUtil.Extensions;
using PrefabUtil.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace PrefabUtil
{
    public class UnityPackageReader
    {
        private string Path;
        private readonly List<FileStructure> InternalPaths;
        private readonly Dictionary<string, string> FileContent;
        public UnityPackageReader()
        {
            InternalPaths = new List<FileStructure>();
            FileContent = new Dictionary<string, string>();
        }
        public UnityPackageReader LoadFile(string FullPath)
        {
            Path = FullPath;
            var stream = File.OpenRead(FullPath);
            using (var gzip = new GZipStream(stream, CompressionMode.Decompress))
            {
                const int chunk = 4096;
                using var memStr = new MemoryStream()
                {
                    Capacity = (int)stream.Length
                };
                memStr.SetLength(stream.Length);
                int read;
                var buffer = new byte[chunk];
                do
                {
                    read = gzip.Read(buffer, 0, chunk);
                    memStr.Write(buffer, 0, read);
                } while (read == chunk);

                memStr.Seek(0, SeekOrigin.Begin);

                buffer = new byte[100];

                while (true)
                {
                    memStr.Read(buffer, 0, 100);
                    var name = Encoding.ASCII.GetString(buffer).Trim('\0');
                    
                    if (string.IsNullOrWhiteSpace(name))
                        break;

                    memStr.Seek(24, SeekOrigin.Current);
                    memStr.Read(buffer, 0, 12);

                    string k = Encoding.Default.GetString(buffer, 0, 12).Trim().Trim('\0');
                    var size = Convert.ToInt64(k, 8);

                    memStr.Seek(376L, SeekOrigin.Current);

                    var buf = new byte[size];
                    memStr.Read(buf, 0, buf.Length);

                    if (!name.EndsWith("/"))
                        InternalPaths.Add(new FileStructure(name, buf));

                    var pos = memStr.Position;

                    var offset = 512 - (pos % 512);
                    if (offset == 512)
                        offset = 0;

                    memStr.Seek(offset, SeekOrigin.Current);
                }
            }
            return this;
        }
        public IEnumerable<Prefab> LoadPrefabs()
        {
            foreach (var item in InternalPaths)
            {
                if (item.internal_path.Replace("\\", "/").Split("/")[^1].Trim().ToLower().Equals("asset"))
                {
                    string content = Encoding.Default.GetString(item.content);
                    FileContent.Add(item.internal_path, content);
                    yield return content.ReadYaml().ToPrefeb();
                }
            }
        }
    }
}
