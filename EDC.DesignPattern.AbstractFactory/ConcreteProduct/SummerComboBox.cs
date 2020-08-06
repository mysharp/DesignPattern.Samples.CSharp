﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
