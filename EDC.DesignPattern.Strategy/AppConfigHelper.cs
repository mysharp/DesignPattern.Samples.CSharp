using System;
using System.Configuration;

namespace EDC.DesignPattern.Strategy
{
    public class AppConfigHelper
    {
        public static string GetStrategyName()
        {
            string factoryName = null;
            try
            {
                factoryName = ConfigurationManager.AppSettings["DiscountStrategy"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return factoryName;
        }

        public static object GetStrategyInstance()
        {
            var assemblyName = GetStrategyName();
            var type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}