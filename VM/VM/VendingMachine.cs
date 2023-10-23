using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VM
{
    internal class VendingMachine
    {
        //Attributes
        private int chocolate;
        private int crisps;
        private int water;

        //Methods

        //Constructor

        public VendingMachine()
        {
             chocolate = 40;
             crisps = 20;
             water = 30;

        }

        public void BuyChocolate(int amount)
        {
            //Buy Chocolate
            chocolate = chocolate - amount;
        }

        public void BuyCrisps(int amount)
        {
            //Buy Crisps
            crisps = crisps - amount;
        }

        public void BuyWater(int amount)
        {
            //Buy Water
            water = water - amount;
        }

        public int CheckStock(string item)
        {

            //Check Chocolate Stock
            item = item.ToLower();
            switch (item)
            {
                case "water":
                    return water;
                case "chocolate":
                    return chocolate;
                case "crisps":
                    return crisps;
                default: return -1;
            }
        }
        public void AddChocolate(int amount)
        {
            //Add Chocolate
            chocolate = chocolate + amount;
        }
        public void AddCrisps(int amount)
        {
            //Add Crisps
            crisps = crisps + amount;
        }
        public void AddWater(int amount)
        {
            //Add Water
            water = water + amount;
        }
    }
}