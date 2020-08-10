using System;

namespace EDC.DesignPattern.Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //InitializeTest();

            var mt = new MovieTicket();
            var originalPrice = 60.0;
            var currentPrice = originalPrice;

            mt.Price = originalPrice;
            Console.WriteLine("原始票价：{0}", originalPrice);
            Console.WriteLine("----------------------------------------");

            var discount = AppConfigHelper.GetStrategyInstance() as IDiscount;
            if (discount != null)
            {
                mt.Discount = discount;
                currentPrice = mt.Price;
            }

            Console.WriteLine("折后票价：{0}", currentPrice);

            Console.ReadKey();
        }

        public static void InitializeTest()
        {
            //MovieTicket mt = new MovieTicket();
            //double originalPrice = 60.0;    // 原始票价
            //double currentPrice;                 // 折后票价
            //mt.Price = originalPrice;

            //Console.WriteLine("原始票价：{0}", originalPrice);
            //Console.WriteLine("----------------------------------------");

            //mt.Type = "student";
            //currentPrice = mt.Calculate();
            //Console.WriteLine("折后票价：{0}", currentPrice);
            //Console.WriteLine("----------------------------------------");

            //mt.Type = "children";
            //currentPrice = mt.Calculate();
            //Console.WriteLine("折后票价：{0}", currentPrice);
            //Console.WriteLine("----------------------------------------");
        }
    }
}