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
    public partial class Delete : Form
    {
        public Delete()
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
                    string salary = myReader.GetString("salary");

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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchFullName = txtSearch.Text.ToLower();
           

            // Loop through each row in the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string fullName = row.Cells["table_fname"].Value.ToString().ToLower() + " " + row.Cells["table_lname"].Value.ToString().ToLower();

                if (fullName == searchFullName)
                {
                    // Retrieve the values for the matched employee
                    string firstname = row.Cells["table_fname"].Value.ToString();
                    string lastName = row.Cells["table_lname"].Value.ToString();
                    string gender = row.Cells["Table_gender"].Value.ToString();
                    string department = row.Cells["table_Department"].Value.ToString();
                    string email = row.Cells["table_email"].Value.ToString();
                    string id = row.Cells["Table_Id"].Value.ToString();
                    string salary = row.Cells["table_salary"].Value.ToString();

                    // Display the values in the respective TextBoxes
                    fname_con.Text = firstname;
                    lname_con.Text = lastName;
                    department_con.Text = department;
                    gender_con.Text = gender;
                    email_con.Text = email;
                    id_con.Text = id;
                    salary_con.Text = salary;


                    // Exit the loop since a match is found
                    txtSearch.Text = "";
                    break;
                }

            }
            }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Load(object sender, EventArgs e)
        {
            loadData();

            fname_con.Clear();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {

            home hm = new home();
            hm.Show();

            this.Close();


        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Are you sure you want to delete this data ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(dialogresult == DialogResult.Yes)
            {
                try
                {
                
                    string ConString = "datasource=localhost;username=root;password=654321";
                    string Query = "DELETE FROM employees.userdata WHERE id = '"+ id_con.Text +"'";
                    MySqlConnection conn = new MySqlConnection(ConString);
                    MySqlCommand cmd = new MySqlCommand(Query, conn);
                    MySqlDataReader myReader;

                    conn.Open();
                    myReader = cmd.ExecuteReader();

                    MessageBox.Show("Data deleted succesfully !", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                      dataGridView1.Rows.Clear();
                      dataGridView1.Refresh();
                    loadData();
                    conn.Close();

                    //  File.Copy(imageTxt.Text, Application.StartupPath + @"\Image\" + Path.GetFileName(pictureBox1.ImageLocation));


                }
                catch (Exception ex)
                {

                    MessageBox.Show("error while running: " + ex);
                }




            }
            else
            {




            }



        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
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
    }
    }

