using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public class ProBusFactory : HomeAutomationFactory//, IHomeAutomationFactory
    {
        public override TemperatureSensor CreateTemperatureSensor()
        {
            return new HomeBusTemperatureSensor();
        }

        public override JalousieControl CreateJalousieControl()
        {
            return new HomeBusJalousieControl();
        }

        /**
        **If you use the interface
        **
        public TemperatureSensor CreateTemperatureSensor()
        {
            return new HomeBusTemperatureSensor();
        }

        public JalousieControl CreateJalousieControl()
        {
            return new HomeBusJalousieControl();
        }*/
    }
}
