using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picHidePass_Click(object sender, EventArgs e)
        {
            //Hides the password
            txtPassword.UseSystemPasswordChar = true;
            //Reveals the ShowPassword button and hides the HidePassword button
            picShowPass.Visible = true;
            picHidePass.Visible = false;
        }

        private void picShowPass_Click(object sender, EventArgs e)
        {
            //Reveals the password
            txtPassword.UseSystemPasswordChar = false;
            //Hides the ShowPassword button and shows the HidePassword button
            picShowPass.Visible = false;
            picHidePass.Visible = true;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            //Attributes
            string username;
            string password;

            username = txtUsername.Text;
            password = txtPassword.Text;

            if (username is null)
            {
                MessageBox.Show("Your username is invalid, please try again");
            }
            if (password is null)
            {
                MessageBox.Show("Your password is invalid, please try again");
            }
            if (password.Length < 8)
            {
                MessageBox.Show("Your password is invalid, please try again");
            }
            else
            {

            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length < 8)
            {
                string message = "Your password needs at least 8 characters";
                new ToolTip().Show(message, this, Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y, 1000);
            }
        }
    }
}
