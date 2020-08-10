using System;
using System.Configuration;

namespace EDC.DesignPattern.Visitor
{
    public class AppConfigHelper
    {
        public static string GetDeptName()
        {
            string factoryName = null;
            try
            {
                factoryName = ConfigurationManager.AppSettings["DeptName"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return factoryName;
        }

        public static object GetDeptInstance()
        {
            var assemblyName = GetDeptName();
            var type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}