using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.SimpleFactory.v1
{
    public class HistogramChart : IChartable
    {
        public HistogramChart()
        {
            Console.WriteLine("Create HistogramChart...");
        }

        public void Display()
        {
            Console.WriteLine("Show HistogramChart...");
        }
    }
}
