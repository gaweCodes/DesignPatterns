using Bridge.Implementers;

namespace Bridge.Abstraction
{
    public abstract class Document
    {
        public StorageProvider StorageProvider { get; }
        public int ReceiptNumber { get; set; }
        public Blob Blob { get; set; }
        protected Document(StorageProvider storageProvider, int receiptNumber)
        {
            StorageProvider = storageProvider;
            ReceiptNumber = receiptNumber;
        }
        public abstract void Load(int receiptNumber);
        public abstract void Save();
        public abstract Blob CreatePrintImage();
    }
}