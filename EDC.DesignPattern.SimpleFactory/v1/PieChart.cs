using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.SimpleFactory.v1
{
    public class PieChart : IChartable
    {
        public PieChart()
        {
            Console.WriteLine("Create PieChart...");
        }

        public void Display()
        {
            Console.WriteLine("Show PieChart...");
        }
    }
}
