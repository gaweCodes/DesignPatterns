using System.Collections.Generic;

namespace Singleton
{
    public sealed class Configuration
    {
        private readonly Dictionary<string, string> _keyValuePairs;
        //Not lazy, but thread save
        private static Configuration _instance = new Configuration();

        private Configuration()
        {
            _keyValuePairs = new Dictionary<string, string>();
            //Read out configurations from file
        }

        public static Configuration GetInstance()
        {
            return _instance ?? (_instance = new Configuration());
        }

        public Dictionary<string, string> GetValues()
        {
            return _keyValuePairs;
        }

        public string GetValueByKey(string key)
        {
            return _keyValuePairs.ContainsKey(key) ? _keyValuePairs[key] : null;
        }

        public void SetValue(string key, string value)
        {
            if (_keyValuePairs.ContainsKey(key))
                _keyValuePairs[key] = value;
            else
                _keyValuePairs.Add(key, value);

            WriteToConfigFile();
        }

        private static void WriteToConfigFile()
        {
            //Write Config back to the file.
        }
    }
}
