using Bridge.Implementers;

namespace Bridge.Abstraction
{
    public class Credit : Document
    {
        private readonly int _assignedInvoiceNumber;
        public Blob InvoiceBlob;
        public Credit(StorageProvider storageProvider, int receiptNumber, int assignedInvoiceNumber) : base(storageProvider, receiptNumber)
        {
            _assignedInvoiceNumber = assignedInvoiceNumber;
        }
        public override void Load(int receiptNumber)
        {
            Blob = StorageProvider.Load(receiptNumber.ToString());
            InvoiceBlob = StorageProvider.Load(_assignedInvoiceNumber.ToString());
            ReceiptNumber = receiptNumber;
        }
        public override void Save()
        {
            StorageProvider.Save(CreatePrintImage(), ReceiptNumber.ToString());
        }
        public override Blob CreatePrintImage()
        {
            //render PDF and return it
            return new Blob("Credit PDF-Content");
        }
    }
}
