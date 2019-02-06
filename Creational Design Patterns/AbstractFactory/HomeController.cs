using AbstractFactory.Factories;
using AbstractFactory.Products;

namespace AbstractFactory
{
    public class HomeController
    {
        //private readonly IHomeAutomationFactory _factory;
        private readonly HomeAutomationFactory _factory;
        private TemperatureSensor _temperatureSensor;
        private JalousieControl _jalousieControl;

        public HomeController(HomeAutomationFactory factory)
        {
            _factory = factory;
            CreateProducts();
        }
        /*public HomeController(IHomeAutomationFactory factory)
        {
            _factory = factory;
            CreateProducts();
        }*/
        private void CreateProducts()
        {
            _temperatureSensor = _factory.CreateTemperatureSensor();
            _jalousieControl = _factory.CreateJalousieControl();
        }

        public double GetCurrentTemperature()
        {
            _temperatureSensor.ReadTemperature();
            return _temperatureSensor.CurrentTemperature;
        }
        public double GetCurrentPosition()
        {
            return _jalousieControl.CurrentPosition;
        }
        public double Open(double value)
        {
            _jalousieControl.Open(value);
            return _jalousieControl.CurrentPosition;
        }
        public double Close(double value)
        {
            _jalousieControl.Close(value);
            return _jalousieControl.CurrentPosition;
        }
    }
}
