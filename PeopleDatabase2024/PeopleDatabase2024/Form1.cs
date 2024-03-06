using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleDatabase2024
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

            string address = txtAddress.Text;

            int telephoneNumber = int.Parse(txtTelephoneNumber.Text);

            //Call stored procedure passing name and age as parameters

            command.Parameters.AddWithValue("@Name", name);

            command.Parameters.AddWithValue("@Age", age);

            command.Parameters.AddWithValue("@Address", address);

            command.Parameters.AddWithValue("@TelephoneNumber", telephoneNumber);

            //Open connection to database, execute stored procedure and close the connection

            sqlConnection.Open();

            command.ExecuteNonQuery();

            sqlConnection.Close();
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            //Read a person record

            List<Person> peopleList = new List<Person>();

            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\M2201992\\OneDrive - Middlesbrough College\\Year 2\\Programming - Trevor\\C#\\PeopleDB2024\\PeopleDB2024.mdf; Integrated Security = True; Connect Timeout = 30";




            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("GetPersonDetails", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sqlConnection.Open();
            sd.Fill(dt);
            sqlConnection.Close();

            foreach (DataRow dr in dt.Rows)
            {
                peopleList.Add(
                    new Person
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Name = Convert.ToString(dr["Name"]),
                        Age = Convert.ToInt32(dr["Age"]),
                        Address = Convert.ToString(dr["Address"]),
                        TelephoneNumber = Convert.ToString(dr["TelephoneNumber"])

                    });
            }

            //Iterate through the student list and put data in textbox
            foreach (Person person in peopleList)
            {
                txtPeople.AppendText(person.Id.ToString() + "\t" + person.Name + "\t" + person.Age.ToString() + "\t" + person.Address + "\t\t\t" + person.TelephoneNumber + Environment.NewLine);
            }
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            //Use stored procedure to delete record(s) containing a given name

            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\M2201992\\OneDrive - Middlesbrough College\\Year 2\\Programming - Trevor\\C#\\PeopleDB2024\\PeopleDB2024.mdf; Integrated Security = True; Connect Timeout = 30";

            SqlConnection sqlConnection = new SqlConnection(connectionString);


            //USE STORED PROCEDURE
            SqlCommand command = new SqlCommand("DeletePerson", sqlConnection);

            command.CommandType = CommandType.StoredProcedure;

            string name = txtDeleteName.Text;

            command.Parameters.AddWithValue("@Name", name);

            int age = int.Parse(txtDeleteAge.Text);

            command.Parameters.AddWithValue("@Age", age);

            sqlConnection.Open();


            command.ExecuteNonQuery();

            sqlConnection.Close();

            txtDeleteAge.Text = "0";

        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\M2201992\\OneDrive - Middlesbrough College\\Year 2\\Programming - Trevor\\C#\\PeopleDB2024\\PeopleDB2024.mdf; Integrated Security = True; Connect Timeout = 30";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //USE STORED PROCEDURE

            SqlCommand command = new SqlCommand("UpdatePerson", sqlConnection);

            command.CommandType = CommandType.StoredProcedure;

            int currentID = int.Parse(txtUpdateID.Text);

            string name = txtUpdateName.Text;

            int age = int.Parse(txtUpdateAge.Text);

            string address = txtUpdateAddress.Text;

            string telephoneNumber = txtUpdateTelephoneNumber.Text;

            command.Parameters.AddWithValue("@StdID", currentID);

            command.Parameters.AddWithValue("@Name", name);

            command.Parameters.AddWithValue("@Age", age);

            command.Parameters.AddWithValue ("@Address", address);

            command.Parameters.AddWithValue("@TelephoneNumber", telephoneNumber);

            sqlConnection.Open();

            command.ExecuteNonQuery();

            sqlConnection.Close();

        }
    }
}

