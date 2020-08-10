using System;
using System.Configuration;

namespace EDC.DesignPattern.AbstractFactory
{
    public class AppConfigHelper
    {
        public static string GetSkinFactoryName()
        {
            string factoryName = null;
            try
            {
                factoryName = ConfigurationManager.AppSettings["SkinFactory"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return factoryName;
        }

        public static object GetSkinFactoryInstance()
        {
            var assemblyName = GetSkinFactoryName();
            var type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}