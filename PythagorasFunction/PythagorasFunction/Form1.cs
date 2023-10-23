using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PythagorasFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Local Variables
            double sideA, sideB, hypotenuse;

            //Input Side A
            sideA = double.Parse(txtSideA.Text);

            //Input Side B
            sideB = double.Parse(txtSideB.Text);

            //Calling the function
            hypotenuse = CalculateHypotenuse(sideA, sideB);

            //Displaying the answer
            DisplayHypotenuse(hypotenuse);

        }

        double CalculateHypotenuse(double mySideA, double mySideB)
        {
            double result, hypotenuse;

            result = mySideA * mySideA + mySideB * mySideB;

            hypotenuse = Math.Sqrt(result);

            return hypotenuse;
        }
        void DisplayHypotenuse(double myHypotenuse)
        {
            txtHypotenuse.Text = myHypotenuse.ToString();
        }

    }
    
        
        
}
