using System;

namespace Decorator
{
    public class AddOnArchiving : ContractAddOn
    {
        public AddOnArchiving(Contract contract) : base(contract) { }
        public void Archive()
        {
            Console.WriteLine("Do the archiving");
        }
    }
}
