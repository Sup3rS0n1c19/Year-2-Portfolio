using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateRoom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Variables

            double roomLength;
            double roomWidth;
            double roomArea;


            //Input Length

            roomLength = double.Parse(txtRoomLength.Text);

            //Input Width

            roomWidth = double.Parse(txtRoomWidth.Text);

            //Calculate Area

            roomArea = roomLength * roomWidth;

            //Output Area

            txtRoomArea.Text = roomArea.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculateVolume_Click(object sender, EventArgs e)
        {
            //Variables

            double length;
            double width;
            double roomHeight;
            double roomVolume;

            //Input Length

            length = double.Parse(txtLength.Text);

            //Input Width

            width = double.Parse(txtWidth.Text);

            //Input Height

            roomHeight = double.Parse(txtRoomHeight.Text);

            //Calculate Volume

            roomVolume = length * width * roomHeight;

            //Output Area

            txtRoomVolume.Text = roomVolume.ToString();



        }
    }
}
