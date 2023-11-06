namespace PrefabUtil.IO
{
    internal class FileStructure
    {
        public string internal_path;
        public byte[] content;
        public FileStructure(string path, byte[] data)
        {
            internal_path = path;
            content = data;
        }
    }
}
