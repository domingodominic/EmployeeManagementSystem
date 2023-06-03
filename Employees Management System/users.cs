using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Employees_Management_System
{
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }

        private void reqBtn_Click(object sender, EventArgs e)
        {



            try
            {
                string fname = Program.firstname;
                string lname = Program.lastname;
              

                // Check if the record already exists in the database
                string checkQuery = "SELECT COUNT(*) FROM employees.leaveRequest WHERE firstname = @FirstName AND lastname = @LastName";
                MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=654321");
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, conn);
                checkCommand.Parameters.AddWithValue("@FirstName", fname);
                checkCommand.Parameters.AddWithValue("@LastName", lname);

                conn.Open();
                int existingRecords = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (existingRecords > 0)
                {
                    // Record already exists, display a message or take appropriate action
                    MessageBox.Show("Record already exists in the database.", "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Record doesn't exist, proceed with the insert
                    status_lb.Text = "pending";
                    string insertQuery = "INSERT INTO employees.leaveRequest(firstname, lastname, status) VALUES (@FirstName, @LastName, @Status)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn);
                    insertCommand.Parameters.AddWithValue("@FirstName", fname);
                    insertCommand.Parameters.AddWithValue("@LastName", lname);
                    insertCommand.Parameters.AddWithValue("@Status", "Pending");

                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Successfully requested for a leave!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while running: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void loadData()
        {
            string ConString = "datasource=localhost;username=root;password=654321";
            string Query = "SELECT * FROM employees.leaveRequest WHERE firstname = @FirstName AND lastname = @LastName";
            MySqlConnection conn = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@FirstName", fname_lb.Text);
            cmd.Parameters.AddWithValue("@LastName", lname_lb.Text);

            try
            {
                conn.Open();
                MySqlDataReader myReader = cmd.ExecuteReader();

                if (myReader.Read())
                {
                    string status = myReader.GetString("status");

                    status_lb.Text = status;

                    if (status.ToLower() == "pending")
                    {
                        status_lb.ForeColor = Color.DarkGray;
                    }
                    else if (status.ToLower() == "accepted")
                    {
                        status_lb.ForeColor = Color.Green;
                    }
                    else if (status.ToLower() == "declined")
                    {
                        status_lb.ForeColor = Color.Red;
                    }
                }
                else
                {
                    // No records found for the specified first name and last name
                    // Handle the case appropriately, e.g., display an error message
                }

                myReader.Close();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during database access
                MessageBox.Show("error : " + ex);
            }
            finally
            {
                conn.Close();
            }
        }


        private void users_Load(object sender, EventArgs e)
        {

            fname_lb.Text = Program.firstname;
            lname_lb.Text = Program.lastname;
       
            
            loadData();

       
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            login lg = new login();

            lg.Show();
            this.Hide();
        }
    }
}
