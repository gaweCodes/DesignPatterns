using System;

namespace Singleton
{
    public class Program
    {
        private static void Main()
        {
            var config = Configuration.GetInstance();
            config.SetValue("key1", "value1");
            config.SetValue("key2", "value2");
            var valueOfKey1 = config.GetValueByKey("key1");
            var values = config.GetValues();
            Console.WriteLine("Key1: " + valueOfKey1);
            foreach (var keyValuePair in values)
                Console.WriteLine(keyValuePair.Key + ": " + keyValuePair.Value);
            Console.ReadLine();
        }
    }
}
