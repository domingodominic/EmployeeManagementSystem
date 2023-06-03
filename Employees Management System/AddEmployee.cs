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
using System.IO;



namespace Employees_Management_System
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            department_cb.SelectedIndex = 0;
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
      
          
         
            

            if (String.IsNullOrEmpty(fname_text.Text) || String.IsNullOrEmpty(lname_text.Text) || department_cb.SelectedIndex == 0 || String.IsNullOrEmpty(salary_text.Text))
            {

                MessageBox.Show("Please complete the information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                decimal incomeTax = .20m;
                int deduction = (int)(incomeTax * Convert.ToInt32(salary_text.Text));
                int mySalary = Convert.ToInt32(salary_text.Text);
                int totalSalary = mySalary - deduction;

                try
                {
                    // '"+Path.GetFileName(pictureBox1.ImageLocation)+"'
                    string selectedRole = department_cb.SelectedItem.ToString();
                    string ConString = "datasource=localhost;username=root;password=654321";
                    string Query = "INSERT INTO employees.userdata(username,password,first_name, last_name, Department,email, gender,salary, roleID) VALUES('"+ username_tx.Text +"', '" + password_tx.Text + "' , '"+fname_text.Text+"','"+lname_text.Text+"','"+ selectedRole +"','"+email_text.Text+"','"+gender_text.Text+"', '"+ totalSalary.ToString() + "' , '"+ "2"  +"')";
                    MySqlConnection conn = new MySqlConnection(ConString);
                    MySqlCommand cmd = new MySqlCommand(Query, conn);
                    MySqlDataReader myReader;

                    conn.Open();
                    myReader = cmd.ExecuteReader();

                    MessageBox.Show("Successfully Added Employee information!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();

                  //  File.Copy(imageTxt.Text, Application.StartupPath + @"\Image\" + Path.GetFileName(pictureBox1.ImageLocation));


                }
                catch (Exception ex)
                {

                    MessageBox.Show("error while running: " + ex);
                }

                fname_text.Clear();
                lname_text.Clear();
                department_cb.SelectedIndex = 0;
                email_text.Clear();
                gender_text.Clear();
                salary_text.Clear();
                username_tx.Clear();
                password_tx.Clear();

                   
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {


            ViewEmployeesData VED = new ViewEmployeesData();

            VED.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Filter = "Image Files(*.jpg;*.jpeg;*gif;) | *.jpg;*.jpeg;*.gif;";
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                imageTxt.Text = openFD.FileName;
                pictureBox1.Image = new Bitmap(openFD.FileName);
                pictureBox1.ImageLocation = openFD.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            } 
        }
    }
}
