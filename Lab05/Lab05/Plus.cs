﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    public class Plus : Operation
    {
        private double num1;
        private double num2;

        public Plus(double number1, double number2)
        {
            this.num1 = number1;
            this.num2 = number2;
        }

        public override double Execute()
        {
            return this.num1 + this.num2;
            throw new NotImplementedException();
        }

        public void Show()
        {
            Console.WriteLine($"Plus");

        }
    }
}
