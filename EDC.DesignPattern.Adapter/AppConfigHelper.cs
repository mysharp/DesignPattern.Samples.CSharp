using System;
using System.Configuration;

namespace EDC.DesignPattern.Adapter
{
    public class AppConfigHelper
    {
        public static string GetAdapterName()
        {
            string factoryName = null;
            try
            {
                factoryName = ConfigurationManager.AppSettings["AdapterName"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return factoryName;
        }

        public static object GetAdapterInstance()
        {
            var assemblyName = GetAdapterName();
            var type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}