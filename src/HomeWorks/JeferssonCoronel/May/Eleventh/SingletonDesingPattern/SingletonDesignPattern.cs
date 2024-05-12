namespace HomeWorks.JeferssonCoronel.May.Eleventh.SingletonDesignPattern
{
    public class ConfigurationManager
    {
        private static ConfigurationManager instance;
        private readonly Dictionary<string, string> configData;

        private ConfigurationManager()
        {
            configData = new Dictionary<string, string>();
        }

        public static ConfigurationManager GetInstance()
        {
            if (instance == null)
            {
                instance = new ConfigurationManager();
            }
            return instance;
        }

        public string GetConfigValue(string key)
        {
            if (configData.ContainsKey(key))
            {
                return configData[key];
            }
            else
            {
                return null;
            }
        }

        public void SetConfigValue(string key, string value)
        {
            configData[key] = value;
        }
    }

    internal static class Program
    {
        static void Main(string[] args)
        {
            var configManager = ConfigurationManager.GetInstance();

            configManager.SetConfigValue("AppLanguage", "English");
            configManager.SetConfigValue("AppTheme", "Dark");

            Console.WriteLine("AppLanguage: " + configManager.GetConfigValue("AppLanguage"));
            Console.WriteLine("AppTheme: " + configManager.GetConfigValue("AppTheme") + "\n");

            // This is other variable but has the same instance so their variables have the same values, and you can change them.
            var configManagerNewVariable = ConfigurationManager.GetInstance();
            configManagerNewVariable.SetConfigValue("AppLanguage", "Spanish");

            Console.WriteLine("AppLanguage: " + configManagerNewVariable.GetConfigValue("AppLanguage"));
            Console.WriteLine("AppTheme: " + configManagerNewVariable.GetConfigValue("AppTheme"));
        }
    }
}
