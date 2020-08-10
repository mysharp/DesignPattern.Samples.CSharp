using System;

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