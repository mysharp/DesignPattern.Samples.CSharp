using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.SimpleFactory.v1
{
    public class LineChart : IChartable
    {
        public LineChart()
        {
            Console.WriteLine("Create LineChart...");
        }

        public void Display()
        {
            Console.WriteLine("Show LineChart...");
        }
    }
}
