using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLoopName
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

        private void btnWriteName_Click(object sender, EventArgs e)
        {
            //Variables

            string name;

            //Input Name

            name = txtEnterName.Text;

            //Writing the Name

            for (int i = 0; i<10; i++)
            {

                txtNameWritten.AppendText(name + Environment.NewLine);

            }
        }
    }
}
