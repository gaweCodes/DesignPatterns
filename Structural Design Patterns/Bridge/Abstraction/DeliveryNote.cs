using Bridge.Implementers;

namespace Bridge.Abstraction
{
    public class DeliveryNote : Document
    {
        public DeliveryNote(StorageProvider storageProvider, int receiptNumber) : base(storageProvider, receiptNumber)
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
            return new Blob("Delivery Note PDF-Content");
        }
    }
}
