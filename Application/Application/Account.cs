using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Account
    {

        //Attributes
        private int accountNumber;
        private string customerName;
        private decimal balance;

        //Methods

        public void MakeDeposit(decimal amount)
        {
            balance = balance + amount;
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}
