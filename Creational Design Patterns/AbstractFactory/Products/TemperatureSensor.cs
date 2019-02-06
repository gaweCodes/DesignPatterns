namespace AbstractFactory.Products
{
    public abstract class TemperatureSensor
    {
        public double CurrentTemperature { get; protected set; }
        public abstract void ReadTemperature();
    }
}
