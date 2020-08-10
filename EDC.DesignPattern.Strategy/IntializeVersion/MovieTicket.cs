using System;

namespace EDC.DesignPattern.Strategy.IntializeVersion
{
    public class MovieTicket
    {
        public double Price { get; set; }

        public string Type { private get; set; }

        // 计算打折之后的票价
        public double Calculate()
        {
            // 学生票折后票价计算
            if (Type.Equals("student", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("学生票：");
                return Price * 0.8;
            }
            // 儿童票折后票价计算

            if (Type.Equals("children", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("儿童票：");
                return Price - 10;
            }
            // VIP票折后票价计算

            if (Type.Equals("vip", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("VIP票：");
                Console.WriteLine("增加积分！");
                return Price * 0.5;
            }

            return Price; // 不满足任何条件则原价出售
        }
    }
}