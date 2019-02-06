namespace AbstractFactory.Products
{
    public class ProBusTemperatureSensor : TemperatureSensor
    {
        public override void ReadTemperature()
        {
            //Here you would add code to communicate with the device to get the required data.
            //We will implement a dummy function.
            const double temperature = 42;
            CurrentTemperature = temperature;
        }
    }
}
