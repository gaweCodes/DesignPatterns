using System;

namespace Multiton
{
    public class DatabaseConnection
    {
        private readonly string _connectionString;
        public DatabaseConnection(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void Open()
        {
            Console.WriteLine("Connection String: " + _connectionString + " is now open.");
        }
    }
}
