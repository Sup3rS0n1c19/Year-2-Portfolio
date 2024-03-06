using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelOOP
{
    public partial class TheEagleHotel : Form
    {
        public TheEagleHotel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Hotel hotel = new Hotel();

        //Attributes


        //Methods

        private void btnBooking_Click(object sender, EventArgs e)
        {        

        }

        private void btnBooking_Click_1(object sender, EventArgs e)
        {
            //input cust name
            string custName = txtCustomerName.Text;

            //input room number
            int roomNumber = int.Parse(txtRoomNumber.Text);

            //call hotel BookRoom method
            hotel.BookRoom(roomNumber, custName);

            //make vacate visible
            grpOptions.Visible = true;   

        }

        private void btnVacate_Click(object sender, EventArgs e)
        {
            //Clearing the customer name
            string custName = "";
        }
    }
}
