using System;

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