using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamGrader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btngradeResults_Click(object sender, EventArgs e)
        {
            //Variables

            int firstResult;
            int secondResult;
            int thirdResult;
            int fourthResult;
            int averageResult;
            string outcome;

            //Input first result

            firstResult = int.Parse(txtFirstResult.Text);

            //Input second result

            secondResult = int.Parse(txtSecondResult.Text);

            //Input third result

            thirdResult = int.Parse(txtThirdResult.Text);

            //Input fourth result

            fourthResult = int.Parse(txtFourthResult.Text);

            //Calculate average result

            averageResult = (firstResult + secondResult + thirdResult + fourthResult) / 4;

            //Determine outcome

            if (averageResult >= 50)
            {
                outcome = "You passed";
            }

            else
            {
                outcome = "You failed";
            }

            //Display outcome

            txtOverallResult.Text = outcome;


            

            
        }
    }
}
