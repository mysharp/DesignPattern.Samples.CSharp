using System;

namespace EDC.DesignPattern.AbstractFactory
{
    public class SpringTextField : ITextField
    {
        public void Display()
        {
            Console.WriteLine("Spring TextField...");
        }
    }
}