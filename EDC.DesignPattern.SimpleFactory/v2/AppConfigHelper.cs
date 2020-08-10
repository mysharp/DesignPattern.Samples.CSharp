using System;
using System.Configuration;

namespace EDC.DesignPattern.SimpleFactory.v2
{
    public class AppConfigHelper
    {
        public static string GetChartType()
        {
            string chartType = null;
            try
            {
                chartType = ConfigurationManager.AppSettings["charttype"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return chartType;
        }
    }
}