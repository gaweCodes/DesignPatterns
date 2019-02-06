using System;
using Bridge.Abstraction;
using Bridge.Implementers;

namespace Bridge
{
    internal class ReceiptManagement
    {
        private static void Main()
        {
            var provider = new FileSystemProvider("c:\\temp");
            var invoice = new Invoice(provider, 67890);
            invoice.Save();
            invoice.Load(67890);
            Console.WriteLine(invoice.Blob.Text);
            var credit = new Credit(provider, 12345, 67890);
            credit.Save();
            credit.Load(12345);
            Console.WriteLine(credit.Blob.Text);
            Console.WriteLine(credit.InvoiceBlob.Text);
            var deliveryNote = new DeliveryNote(provider, 54321);
            deliveryNote.Save();
            deliveryNote.Load(54321);
            Console.WriteLine(deliveryNote.Blob.Text);
            Console.ReadLine();
        }
    }
}
