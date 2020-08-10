using System;

namespace EDC.DesignPattern.AbstractFactory
{
    public class SummerComboBox : IComboBox
    {
        public void Display()
        {
            Console.WriteLine("Summer ComboBox...");
        }
    }
}