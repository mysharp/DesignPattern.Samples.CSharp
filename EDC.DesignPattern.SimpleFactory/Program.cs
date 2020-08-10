using System;
using EDC.DesignPattern.SimpleFactory.v1;
using EDC.DesignPattern.SimpleFactory.v2;

namespace EDC.DesignPattern.SimpleFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // v1.0
            //ClientV1();

            //Console.WriteLine();

            // v2.0
            ClientV2();

            Console.ReadKey();
        }

        public static void ClientV1()
        {
            var chart = ChartFactory.GetChart("histogram");
            if (chart != null) chart.Display();

            chart = ChartFactory.GetChart("pie");
            if (chart != null) chart.Display();
        }

        public static void ClientV2()
        {
            var type = AppConfigHelper.GetChartType();
            if (string.IsNullOrEmpty(type)) return;

            var chart = ChartFactory.GetChart(type);
            if (chart != null) chart.Display();
        }
    }
}