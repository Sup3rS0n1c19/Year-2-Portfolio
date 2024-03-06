using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOOP
{
    class Hotel
    {
        private Dictionary<int, Room> rooms = new Dictionary<int, Room>();


        //Attributes

        //Methods

        //Constructor

        public Hotel()
        {


            for(int i = 1; i <=40;  i++)
            {
                rooms.Add(i, new Room());
            }
        }

        public void ReportOnRooms()
        {

        }

        public void BookRoom(int roomnum, string custName)
        {
            rooms[roomnum].OccupyRoom(custName);
        }

        public void VacateRoom()
        {

        }

        public void CountCustomers()
        {

        }

        public void ShowIncome()
        {

        }
    }
}
