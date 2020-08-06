using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.SimpleFactory.v1
{
    public class ChartFactory
    {
        public static IChartable GetChart(string type)
        {
            IChartable chart = null;

            if (type.Equals("histogram", StringComparison.OrdinalIgnoreCase))
            {
                chart = new HistogramChart();
                Console.WriteLine("Init Histogram Chart...");
            }
            else if (type.Equals("pie", StringComparison.OrdinalIgnoreCase))
            {
                chart = new PieChart();
                Console.WriteLine("Init Pie Chart...");
            }
            else if (type.Equals("line", StringComparison.OrdinalIgnoreCase))
            {
                chart = new LineChart();
                Console.WriteLine("Init Line Chart...");
            }

            return chart;
        }
    }
}
