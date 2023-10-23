using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversionCalculator
{
    public partial class ConversionCalculator : Form
    {
        public ConversionCalculator()
        {
            InitializeComponent();
        }

        private void btnMetreConverter_Click(object sender, EventArgs e)
        {
            //Variables

            double metres;
            double feet;

            //Input metres

            metres = double.Parse(txtMetres.Text);

            //Calculate Feet

            feet = metres * 3.28;

            //Output Feet

            txtFeet.Text = feet.ToString();
        }

        private void btnKilogramConverter_Click(object sender, EventArgs e)
        {
            //Variables

            double kilograms;
            double pounds;

            //Input Kilograms

            kilograms = double.Parse(txtKilograms.Text);

            //Calculate Pounds

            pounds = kilograms * 2.2;

            //Output Pounds

            txtPounds.Text = pounds.ToString();
        }

        private void btnLitreConverter_Click(object sender, EventArgs e)
        {
            //Variables

            double litres;
            double gallons;

            //Input Litres

            litres = double.Parse(txtLitres.Text);

            //Calculate Gallons

            gallons = litres * 0.264;

            //Output Gallons

            txtGallons.Text = gallons.ToString();
        }
    }
}
