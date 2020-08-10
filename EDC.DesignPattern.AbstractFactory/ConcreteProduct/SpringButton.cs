using System;

namespace EDC.DesignPattern.AbstractFactory
{
    public class SpringButton : IButton
    {
        public void Display()
        {
            Console.WriteLine("Spring Button...");
        }
    }
}