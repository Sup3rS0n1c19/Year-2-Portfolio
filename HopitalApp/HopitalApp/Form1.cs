using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopitalApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {


            if (txtPassword.Text.Length < 8)
            {
                string message = "Your password needs at least 8 characters";
                new ToolTip().Show(message, this, Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y, 1000);
            }

        }
        public static bool HasUpperLowerDigit(string text)
        {
            {
                bool hasUpper = false; bool hasLower = false; bool hasDigit = false;
                for (int i = 0; i < text.Length && !(hasUpper && hasLower && hasDigit); i++)
                {
                    char c = text[i];
                    if (!hasUpper) hasUpper = char.IsUpper(c);
                    if (!hasLower) hasLower = char.IsLower(c);
                    if (!hasDigit) hasDigit = char.IsDigit(c);
                }
                return hasUpper && hasLower && hasDigit;
            }
           
        }
    }
}
