using System;

namespace EDC.DesignPattern.AbstractFactory
{
    public class SpringComboBox : IComboBox
    {
        public void Display()
        {
            Console.WriteLine("Spring ComboBox...");
        }
    }
}