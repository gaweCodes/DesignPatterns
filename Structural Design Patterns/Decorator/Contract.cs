using System;

namespace Decorator
{
    public abstract class Contract
    {
        public DateTime ContractStart { get; set; }
        public DateTime ContractEnd { get; set; }
        public bool Released { get; set; }
        protected Contract()
        {
            Released = false;
        }
        public abstract void Release();
        public abstract void Cancel(DateTime cancelDate);
    }
}
