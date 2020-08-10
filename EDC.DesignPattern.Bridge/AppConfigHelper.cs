using System;
using System.Configuration;

namespace EDC.DesignPattern.Bridge
{
    public class AppConfigHelper
    {
        public static string GetImageFormatName()
        {
            string factoryName = null;
            try
            {
                factoryName = ConfigurationManager.AppSettings["RefinedAbstraction"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return factoryName;
        }

        public static object GetImageInstance()
        {
            var assemblyName = GetImageFormatName();
            var type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }

        public static string GetEnvName()
        {
            string factoryName = null;
            try
            {
                factoryName = ConfigurationManager.AppSettings["ConcreteImplementor"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return factoryName;
        }

        public static object GetEnvInstance()
        {
            var assemblyName = GetEnvName();
            var type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}