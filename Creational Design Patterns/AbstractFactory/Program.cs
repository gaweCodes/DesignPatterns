using System;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    internal class Program
    {
        private static void Main()
        {
            /**
            * Usage with Singleton
            HomeAutomationFactory.Initialize(new ProBusFactory());
            var jc = HomeAutomationFactory.GetInstance().CreateJalousieControl();
            jc.Close(50);
            jc.Open(13);*/
            
            var controller = new HomeController(new ProBusFactory());
            Console.WriteLine("Temperature: " + controller.GetCurrentTemperature());
            Console.WriteLine("Starting Position: " + controller.GetCurrentPosition());
            Console.ReadLine();
            controller.Close(50);
            Console.WriteLine("Temperature: " + controller.GetCurrentTemperature());
            Console.WriteLine("Current Position: " + controller.GetCurrentPosition());
            Console.ReadLine();
            controller.Open(25);
            Console.WriteLine("Temperature: " + controller.GetCurrentTemperature());
            Console.WriteLine("Current Position: " + controller.GetCurrentPosition());
            Console.ReadLine();
            //You can do this 
        }
    }
}
