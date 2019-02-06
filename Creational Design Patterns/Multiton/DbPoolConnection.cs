using System.Collections.Generic;

namespace Multiton
{
    public class DbPoolConnection
    {
        private static readonly Dictionary<int, DbPoolConnection> Instances = new Dictionary<int, DbPoolConnection>();
        private readonly DatabaseConnection _dbConnection;

        private DbPoolConnection()
        {
            _dbConnection = new DatabaseConnection("A connection-string");
            _dbConnection.Open();
        }

        public DatabaseConnection GetDatabaseConnection()
        {
            return _dbConnection;
        }

        public static DbPoolConnection GetInstance(int key)
        {
            lock (Instances)
            {
                DbPoolConnection instance;
                if (!Instances.ContainsKey(key))
                {
                    instance = new DbPoolConnection();
                    Instances.Add(key, instance);
                }
                else
                    instance = Instances[key];
                return instance;
            }
        }
    }
}