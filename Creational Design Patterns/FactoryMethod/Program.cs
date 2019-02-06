using System;
using FactoryMethod.Factory;
using FactoryMethod.Products;

namespace FactoryMethod
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var objectWithoutParameter = MyObject.GetFactory().Create();
            var objectWithParameter = MyObject.GetFactory().Create("a simple parameter");

            var factory = new MyFactory("default parameter");
            var objectWithoutDefaultParameter = factory.Create();

            Console.WriteLine(objectWithoutParameter.ToString());
            Console.WriteLine(objectWithParameter.ToString());
            Console.WriteLine(objectWithoutDefaultParameter.ToString());
            Console.Read();
        }
    }
}
