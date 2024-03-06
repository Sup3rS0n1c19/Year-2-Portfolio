using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelsiusToFahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Attributes
        double celsius;
        double fahrenheit;

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                celsius = double.Parse(txtCelsius.Text);

                fahrenheit = ((celsius * 9) / 5 + 32);

                MessageBox.Show("Fahrenheit = " + fahrenheit);

                if (celsius > 100)
                    MessageBox.Show("Temperature out of range. ");

                if (celsius < -100)
                    MessageBox.Show("Temperature out of range. ");

            }
            catch(Exception ex)
            {
                MessageBox.Show("An exception has occurred. " + ex.Message);
            }
        }
    }
}
