using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
