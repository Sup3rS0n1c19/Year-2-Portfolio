using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThemeParkManaager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Attributes
        double tickets;
        double price;
        double totalCost;

        private void btnTicketResults_Click(object sender, EventArgs e) {

            try
            {
                tickets = double.Parse(txtTickets.Text);
                price = 10.99;

                totalCost = tickets * price;

                if (totalCost > 40000)
                {
                    MessageBox.Show("Ticket sales are high");
                }
                else
                {
                    MessageBox.Show("Ticket sales are low");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("An exception has occurred. " + ex.Message);
            } 
        }
    }
}
