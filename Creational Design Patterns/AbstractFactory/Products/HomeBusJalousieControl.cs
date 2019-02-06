namespace AbstractFactory.Products
{
    public class HomeBusJalousieControl : JalousieControl
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
