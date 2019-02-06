using System;

namespace Multiton
{
    internal class Program
    {
        private static void Main()
        {
            var poolObject = DbPoolConnection.GetInstance(5);
            poolObject.GetDatabaseConnection();
            Console.ReadLine();
        }
    }
}