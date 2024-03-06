using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Attributes
        int num1;
        int num2;
        int answer;

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                num1 = int.Parse(textBox1.Text);
                num2 = int.Parse(textBox2.Text);

                answer = num1 / num2;

                MessageBox.Show("Answer is " + answer);

            }
            catch(Exception ex) 
            {
                MessageBox.Show("An exception has occured. " + ex.Message);
            }




        }
    }
}
