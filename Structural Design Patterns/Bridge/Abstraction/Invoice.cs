using Bridge.Implementers;

namespace Bridge.Abstraction
{
    public class Invoice : Document
    {
        public Invoice(StorageProvider storageProvider, int receiptNumber) : base(storageProvider, receiptNumber)
        {
        }
        public override void Load(int receiptNumber)
        {
            Blob = StorageProvider.Load(receiptNumber.ToString());
        }

        public override void Save()
        {
            StorageProvider.Save(CreatePrintImage(), ReceiptNumber.ToString());
        }

        public override Blob CreatePrintImage()
        {
            //render PDF and return it
            return new Blob("Invoice PDF-Content");
        }
    }
}
