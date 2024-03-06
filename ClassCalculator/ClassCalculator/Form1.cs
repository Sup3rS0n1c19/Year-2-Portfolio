using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Attriibutes
        double number1;
        double number2;
        double result;
        string symbol;

        //Creating a calculator
        Calculator calculator = new Calculator();
  

        private void calculateResult_Click(object sender, EventArgs e)
        {
            //Input Number 1
            number1 = double.Parse(txtNumber1.Text);


           //Input Number 
           number2 = double.Parse(txtNumber2.Text);

            //Input Equation Symbol
            symbol = txtEquationSymbol.Text;

            //Checking the inputted equation
            switch (symbol)
            {
                case "+":
                    result = calculator.Add(number1, number2);
                    MessageBox.Show("The answer is " + result.ToString());
                    break;
                case "-":
                    result = calculator.Subtract(number1, number2);
                    MessageBox.Show("The answer is: " + result.ToString());
                    break;
                case "*":
                    result = calculator.Multiply(number1, number2);
                    MessageBox.Show("The answer is " + result.ToString());
                    break;
                case "/":
                    result = calculator.Divide(number1, number2);
                    MessageBox.Show("The answer is:" + result.ToString());
                    break;
            }
            
             
            

        }
    }
}
