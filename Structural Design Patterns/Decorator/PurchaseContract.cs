using System;

namespace Decorator
{
    public class PurchaseContract : Contract
    {
        public override void Release()
        {
            Released = Validate();
        }
        public override void Cancel(DateTime cancelDate)
        {
            if (cancelDate > ContractStart)
                ContractEnd = cancelDate;
        }
        private bool Validate()
        {
            //Here you should develop an logic to to validate your contracts.
            return true;
        }
    }
}
