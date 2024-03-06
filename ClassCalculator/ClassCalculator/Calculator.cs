using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCalculator
{
    internal class Calculator
    {
        //Attributes
        private double number1;
        private double number2;
        private double result;

        //Methods

        public double Add(double number1, double number2)
        {
            //Addition of number 1 and number 2
            result = number1 + number2;
            return result;
        }

        public double Subtract(double number1, double number2)
        {
            //Subtraction of number 1 and number 2
            result = number1 - number2;
            return result;
        }

        public double Multiply(double number1, double number2)
        {
            //Multiplication of number 1 and number 2
            result = number1 * number2;
            return result;
        }

        public double Divide(double number1, double number2)
        {
            //Division of number 1 and number 2
            result = number1 / number2;
            return result;
        }

    }
}
