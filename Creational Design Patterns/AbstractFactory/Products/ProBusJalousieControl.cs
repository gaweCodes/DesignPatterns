namespace AbstractFactory.Products
{
    public class ProBusJalousieControl : JalousieControl
    {
        public override void Open(double value)
        {
            //Communicate with Hardware
            base.Open(value);
        }
        public override void Close(double value)
        {
            //Communicate with Hardware
            base.Close(value);
        }
    }
}
