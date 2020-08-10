using System;
using System.Configuration;

namespace EDC.DesignPattern.TemplateMethod
{
    public class AppConfigHelper
    {
        public static string GetAccountTypeName()
        {
            string factoryName = null;
            try
            {
                factoryName = ConfigurationManager.AppSettings["AccountType"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return factoryName;
        }

        public static object GetAccountInstance()
        {
            var assemblyName = GetAccountTypeName();
            var type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}