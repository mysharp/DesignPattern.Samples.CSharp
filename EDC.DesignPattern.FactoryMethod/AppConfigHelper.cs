using System;
using System.Configuration;

namespace EDC.DesignPattern.Builder
{
    public class AppConfigHelper
    {
        public static string GetLoggerFactoryName()
        {
            string factoryName = null;
            try
            {
                factoryName = ConfigurationManager.AppSettings["LoggerFactory"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return factoryName;
        }

        public static object GetLoggerFactoryInstance()
        {
            var assemblyName = GetLoggerFactoryName();
            var type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}