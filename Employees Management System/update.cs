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
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            string ConString = "datasource=localhost;username=root;password=654321";
            string Query = "SELECT * FROM employees.userdata";
            MySqlConnection conn = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            MySqlDataReader myReader;

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {

                    string fname = myReader.GetString("first_name");
                    string lname = myReader.GetString("last_name");
                    string department = myReader.GetString("Department");
                    string email = myReader.GetString("email");
                    string gender = myReader.GetString("gender");
                    string id = myReader.GetString("id");
                    string salary = myReader.GetString("Salary");

                    dataGridView1.Rows.Add(id, fname, lname, email, gender, department, salary);
                    fname_con.Text = fname;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error while connecting: " + ex);
            }

            conn.Close();
        }
        private void update_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {

              

                string idValue = row.Cells[0].Value.ToString();
                string fnameValue = row.Cells[1].Value.ToString();
                string lnameValue = row.Cells[2].Value.ToString();
                string emailValue = row.Cells[3].Value.ToString();
                string genderValue = row.Cells[4].Value.ToString();
                string departmentValue = row.Cells[5].Value.ToString();
                string salaryValue = row.Cells[6].Value.ToString();


                fname_con.Text = fnameValue;
                lname_con.Text = lnameValue;
                department_con.Text = departmentValue;
                email_con.Text = emailValue;
                gender_con.Text = genderValue;
                id_con.Text = idValue;
                salary_con.Text = salaryValue;
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {


            try
            {

                string ConString = "datasource=localhost;username=root;password=654321";
                string Query = "UPDATE employees.userdata SET first_name = '" + fname_con.Text + "', last_name = '" + lname_con.Text + "', Department = '" + department_con.Text + "', gender = '" + gender_con.Text + "', email = '" + gender_con.Text + "' WHERE id = '" + id_con.Text + "'";
                MySqlConnection conn = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(Query, conn);
                MySqlDataReader myReader;

                conn.Open();
                myReader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                loadData();

                MessageBox.Show("Successfully Update Employee information!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);


                conn.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("error while running: " + ex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchFirstName = txtSearch.Text.ToLower();

            // Loop through each row in the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string firstName = row.Cells["table_fname"].Value.ToString().ToLower();

                if (firstName == searchFirstName)
                {
                    // Retrieve the values for the matched employee
                    string lastName = row.Cells["table_lname"].Value.ToString();
                    string gender = row.Cells["Table_gender"].Value.ToString();
                    string department = row.Cells["table_Department"].Value.ToString();
                    string email = row.Cells["table_email"].Value.ToString();
                    string id = row.Cells["Table_Id"].Value.ToString();

                    // Display the values in the respective TextBoxes
                    fname_con.Text = searchFirstName;
                    lname_con.Text = lastName;
                    department_con.Text = department;
                    gender_con.Text = gender;
                    email_con.Text = email;
                    id_con.Text = id;


                    // Exit the loop since a match is found
                    txtSearch.Text = "";
                    break;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
