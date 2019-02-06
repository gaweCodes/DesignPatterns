namespace Bridge.Implementers
{
    public abstract class StorageProvider
    {
        public abstract Blob Load(string refId);
        public abstract void Save(Blob blob, string refId);
    }
}
