using System;

namespace Decorator
{
    public class AddOnEncryption : ContractAddOn
    {
        public AddOnEncryption(Contract contract) : base(contract) { }
        public void Encrypt()
        {
            Console.WriteLine("Use an encryption API...");
        }
    }
}
