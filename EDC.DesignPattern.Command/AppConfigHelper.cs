using System;
using System.Configuration;

namespace EDC.DesignPattern.Command
{
    public class AppConfigHelper
    {
        public static string GetCommandAName()
        {
            string factoryName = null;
            try
            {
                factoryName = ConfigurationManager.AppSettings["HelpCommand"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return factoryName;
        }

        public static object GetCommandAInstance()
        {
            var assemblyName = GetCommandAName();
            var type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }

        public static string GetCommandBName()
        {
            string factoryName = null;
            try
            {
                factoryName = ConfigurationManager.AppSettings["MinimizeCommand"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return factoryName;
        }

        public static object GetCommandBInstance()
        {
            var assemblyName = GetCommandBName();
            var type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}