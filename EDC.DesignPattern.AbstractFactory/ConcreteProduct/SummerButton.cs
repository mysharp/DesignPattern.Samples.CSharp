using System;

namespace EDC.DesignPattern.AbstractFactory
{
    public class SummerButton : IButton
    {
        public void Display()
        {
            Console.WriteLine("Summer Button...");
        }
    }
}