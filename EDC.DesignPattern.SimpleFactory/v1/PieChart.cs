using System;

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