﻿using System;

namespace EDC.DesignPattern.Prototype
{
    public class SRS : OfficeDocument
    {
        public OfficeDocument Clone()
        {
            return new SRS();
        }

        public void Display()
        {
            Console.WriteLine("<<软件需求规格说明书>>");
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}