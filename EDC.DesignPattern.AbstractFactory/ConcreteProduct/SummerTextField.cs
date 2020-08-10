using System;

namespace EDC.DesignPattern.AbstractFactory
{
    public class SummerTextField : ITextField
    {
        public void Display()
        {
            Console.WriteLine("Summer TextField...");
        }
    }
}