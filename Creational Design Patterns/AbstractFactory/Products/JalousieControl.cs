namespace AbstractFactory.Products
{
    public abstract class JalousieControl
    {
        public double CurrentPosition { get; protected set; }
        public virtual void Open(double value)
        {
            var finalValue = CurrentPosition - value;
            if (finalValue < 0)
                CurrentPosition = 0;
            CurrentPosition = finalValue;
            //Call intern Method
        }
        public virtual void Close(double value)
        {
            var finalValue = CurrentPosition + value;
            if (finalValue > 100)
                CurrentPosition = 100;
            CurrentPosition = finalValue;
            //Call intern Method
        }
    }
}
