using System;

namespace Decorator
{
    public abstract class ContractAddOn : Contract
    {
        public Contract Contract { get; }
        protected ContractAddOn(Contract contract)
        {
            Contract = contract;
        }
        public override void Release()
        {
            Contract.Release();
        }
        public override void Cancel(DateTime cancelDate)
        {
            Contract.Cancel(cancelDate);
        }
    }
}
