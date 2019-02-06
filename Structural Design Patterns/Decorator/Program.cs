using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var purchaseContract = new PurchaseContract();
            purchaseContract.Release();
            Console.WriteLine(purchaseContract.Released);
            Console.ReadLine();

            var purchaseContractWithArchiving = new AddOnArchiving(purchaseContract);
            purchaseContractWithArchiving.Release();
            Console.WriteLine(purchaseContractWithArchiving.Contract.Released);
            purchaseContractWithArchiving.Archive();
            Console.ReadLine();

            var purchaseContractWithBoth = new AddOnEncryption(purchaseContractWithArchiving);
            purchaseContractWithBoth.Release();
            Console.WriteLine(purchaseContractWithBoth.Contract.Released);
            purchaseContractWithBoth.Encrypt();
            ((AddOnArchiving)purchaseContractWithBoth.Contract).Archive();
            Console.ReadLine();
        }
    }
}
