using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public abstract class HomeAutomationFactory
    {
        public abstract TemperatureSensor CreateTemperatureSensor();
        public abstract JalousieControl CreateJalousieControl();
    }
}