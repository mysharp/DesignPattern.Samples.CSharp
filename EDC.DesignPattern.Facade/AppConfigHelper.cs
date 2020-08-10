using System;
using System.Configuration;

namespace EDC.DesignPattern.Facade
{
    public class AppConfigHelper
    {
        public static string GetFacadeName()
        {
            string factoryName = null;
            try
            {
                factoryName = ConfigurationManager.AppSettings["EncryptFacadeName"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return factoryName;
        }

        public static object GetFacadeInstance()
        {
            var assemblyName = GetFacadeName();
            var type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}