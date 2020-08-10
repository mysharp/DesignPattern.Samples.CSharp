﻿using System;

namespace EDC.DesignPattern.Prototype
{
    public class FAR : OfficeDocument
    {
        public OfficeDocument Clone()
        {
            return new FAR();
        }

        public void Display()
        {
            Console.WriteLine("<<可行性分析报告>>");
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}