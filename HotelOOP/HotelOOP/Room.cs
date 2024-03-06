using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HotelOOP
{
    class Room
    {


        //Attributes

        private int roomNumber;
        private bool roomStatus;
        private Customer customer;

        //Methods

        //Constructor

        public Room()
        {
            roomNumber = 1; 
            roomStatus = false;

        }

        public int GetRoomNumber()
        { 
            return roomNumber; 
        }

        public bool IsOccupied() 
        {
            return roomStatus;
        }

        public void OccupyRoom(string customerName)
        {
            roomStatus = true;

            //Creating a customer object
            
            customer = new Customer(customerName);
        }

        public void Vacate()
        {

        }
    }
}
