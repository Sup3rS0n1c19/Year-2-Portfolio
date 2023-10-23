using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        VendingMachine vendingMachine = new VendingMachine();

        //Attributes

        string item;
        int result;

        private void btnBuyItem_Click(object sender, EventArgs e)
        {
            item = txtItem.Text.ToLower();
            if (item == "chocolate")
            {
                vendingMachine.BuyChocolate(1);
            }
            if (item == "crisps")
            {
                vendingMachine.BuyCrisps(1);
            }
            if(item == "water")
            {
                vendingMachine.BuyWater(1);
            }
                

        }

        private void btnCheckStock_Click(object sender, EventArgs e)
        {
            item = txtItem.Text.ToLower();
            if (item == "chocolate")
            {
                result = vendingMachine.CheckStock("chocolate");
                MessageBox.Show("Chocolate: " + result.ToString());

            }
            if (item == "crisps")
            {
                result = vendingMachine.CheckStock("crisps");
                MessageBox.Show("Crisps: " + result.ToString());

            }
            if (item == "water")
            {
                result = vendingMachine.CheckStock("water");
                MessageBox.Show("Water: " + result.ToString());
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            item = txtItem.Text.ToLower();
            if (item == "chocolate")
            {
                vendingMachine.AddChocolate(1);
            }
            if (item == "crisps")
            {
                vendingMachine.AddCrisps(1);
            }
            if (item == "water")
            {
                vendingMachine.AddWater(1);
            }
        }

    }
}
