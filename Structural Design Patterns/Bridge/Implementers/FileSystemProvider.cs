using System;
using System.IO;

namespace Bridge.Implementers
{
    public class FileSystemProvider : StorageProvider
    {
        private readonly string _path;
        public FileSystemProvider(string path)
        {
            _path = path;
        }
        public override Blob Load(string refId)
        {
            try
            {
                var text = File.ReadAllText(Path.Combine(_path, refId));
                return new Blob(text);
            }
            catch (Exception ex)
            {
                return new Blob(ex.Message);
            }
        }
        public override void Save(Blob blob, string refId)
        {
            var filePath = Path.Combine(_path, refId);
            File.WriteAllText(filePath, blob.Text);
        }
    }
}