/*using AbstractFactory.Products;
using Microsoft.CSharp.RuntimeBinder;

namespace AbstractFactory.Factories
{
    /**
     * Singleton
     */
    /*public abstract class HomeAutomationFactory
    {
        private static HomeAutomationFactory _instance;
        public abstract TemperatureSensor CreateTemperatureSensor();
        public abstract JalousieControl CreateJalousieControl();
        public static void Initialize(HomeAutomationFactory factory)
        {
            _instance = factory;
        }
        public static HomeAutomationFactory GetInstance()
        {
            if (_instance != null)
                return _instance;
            throw new RuntimeBinderException("Pleas initialize the factory first.");
        }
    }
}*/