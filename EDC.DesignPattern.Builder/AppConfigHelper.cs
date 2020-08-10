using System;
using System.Configuration;

namespace EDC.DesignPattern.Builder
{
    public class AppConfigHelper
    {
        public static string GetConcreteBuilderName()
        {
            string factoryName = null;
            try
            {
                factoryName = ConfigurationManager.AppSettings["ConcreteBuilder"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return factoryName;
        }

        public static object GetConcreteBuilderInstance()
        {
            var assemblyName = GetConcreteBuilderName();
            var type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}