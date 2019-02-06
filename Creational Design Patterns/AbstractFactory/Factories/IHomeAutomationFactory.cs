using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public interface IHomeAutomationFactory
    {
        TemperatureSensor CreateTemperatureSensor();
        JalousieControl CreateJalousieControl();
    }
}