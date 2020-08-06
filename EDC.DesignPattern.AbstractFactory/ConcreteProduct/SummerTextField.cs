using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
