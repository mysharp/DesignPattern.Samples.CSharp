using System;
using System.Configuration;

namespace EDC.DesignPattern.Proxy
{
    public class AppConfigHelper
    {
        public static string GetProxyName()
        {
            string factoryName = null;
            try
            {
                factoryName = ConfigurationManager.AppSettings["ProxyName"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return factoryName;
        }

        public static object GetProxyInstance()
        {
            var assemblyName = GetProxyName();
            var type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}