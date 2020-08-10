using System;

namespace EDC.DesignPattern.Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Component component = new Window();
            // 一次装饰
            Component componentWithScrollBar = new ScrollBarDecorator(component);
            componentWithScrollBar.Display();

            Console.WriteLine();
            // 二次装饰
            Component componentWithScrollBarAndBlackBorder = new BlackBorderDecorator(componentWithScrollBar);
            componentWithScrollBarAndBlackBorder.Display();

            Console.ReadKey();
        }
    }
}