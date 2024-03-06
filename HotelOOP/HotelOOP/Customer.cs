using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOOP
{
    class Customer
    {
        //Attributes
        private string customerName;

        //Methods

        public Customer(string custName) 
        {
            customerName = custName;

        }

       public string GetName()
        {
            return customerName;
        }

    }
}
