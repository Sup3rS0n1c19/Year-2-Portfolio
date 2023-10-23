using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Account object

        Account account1;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            //Create an account

            account1 = new Account();

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //Make a deposit

            //Input deposit amount

            decimal depositAmount = decimal.Parse(txtAmount.Text);
            
            //Using the MakeDeposit method
            account1.MakeDeposit(depositAmount);
        }

        private void btnDisplayBalance_Click(object sender, EventArgs e)
        {
            //Display the balance

            decimal myBalance = account1.GetBalance();

            MessageBox.Show("Your balance is £" + myBalance);
        }
    }
}
