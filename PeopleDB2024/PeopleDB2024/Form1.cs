using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleDB2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            //Tells the code where the database is
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\M2201992\\OneDrive - Middlesbrough College\\Year 2\\Programming - Trevor\\C#\\PeopleDB2024\\PeopleDB2024.mdf; Integrated Security = True; Connect Timeout = 30";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Use stored procedure

            SqlCommand command = new SqlCommand("CreateNewPersonRecord", sqlConnection);

            command.CommandType = CommandType.StoredProcedure;

            //Input name and age from form

            string name = txtName.Text;

            int age = int.Parse(txtAge.Text);

            //Call stored procedure passing name and age as parameters

            command.Parameters.AddWithValue("@Name", name);

            command.Parameters.AddWithValue("@Age", age);

            //Open connection to database, execute stored procedure and close the connection

            sqlConnection.Open();

            command.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}