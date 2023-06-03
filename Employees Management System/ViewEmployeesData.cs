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
using System.Drawing.Printing;

namespace Employees_Management_System
{
   
    public partial class ViewEmployeesData : Form
    {
        private PrintDocument printDocument;
        public ViewEmployeesData()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

            string fnameBold = "FIRSTNAME : \t", lnameBold = "LASTNAME : \t", departmentBold = "DEPARTMENT : \t", salaryBold = "SALARY : \t", genderBold = "GENDER : \t", emailBold = "EMAIL :\t";


            Font headerFont = new Font("Arial", 16, FontStyle.Bold);

            Font fnameBoldFont = new Font("Arial", 12, FontStyle.Bold);
            Font fnameRegFont = new Font("Arial", 12, FontStyle.Regular);


            SolidBrush brush = new SolidBrush(Color.Black);
            float x = 120;
            float y = 70;
            float rightX = 450;
            float rightY = 70;

            float yy = 10;
            float xx = 330;
            // Draw the header on the printing page
            e.Graphics.DrawString("Employees Data", headerFont, brush, xx, yy);

            // Move down the Y coordinate for the content
          

            // Draw the information on the printing page
            e.Graphics.DrawString(fnameBold, fnameBoldFont, brush, x, y);
            e.Graphics.DrawString(fname_con.Text, fnameRegFont, brush, x + e.Graphics.MeasureString(fnameBold, fnameBoldFont).Width , y);

            e.Graphics.DrawString( lnameBold, fnameBoldFont, brush, rightX, rightY);
            e.Graphics.DrawString(lname_con.Text, fnameRegFont, brush, rightX + e.Graphics.MeasureString(lnameBold, fnameBoldFont).Width, rightY);

           e.Graphics.DrawString( Environment.NewLine + Environment.NewLine + departmentBold, fnameBoldFont, brush, x, y);
            e.Graphics.DrawString(Environment.NewLine + Environment.NewLine + department_con.Text, fnameRegFont, brush, x + e.Graphics.MeasureString( departmentBold, fnameBoldFont).Width, y);

            e.Graphics.DrawString(Environment.NewLine + Environment.NewLine + salaryBold, fnameBoldFont, brush, rightX, rightY);
            e.Graphics.DrawString(Environment.NewLine + Environment.NewLine + salary_con.Text, fnameRegFont, brush, rightX + e.Graphics.MeasureString(salaryBold, fnameBoldFont).Width, rightY);

            e.Graphics.DrawString(Environment.NewLine + Environment.NewLine + Environment.NewLine + genderBold, fnameBoldFont, brush, x, y);
            e.Graphics.DrawString(Environment.NewLine + Environment.NewLine + Environment.NewLine + gender_con.Text, fnameRegFont, brush, x + e.Graphics.MeasureString(genderBold, fnameBoldFont).Width, y);

            e.Graphics.DrawString(Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + emailBold, fnameBoldFont, brush, rightX, rightY);
            e.Graphics.DrawString(Environment.NewLine + Environment.NewLine + Environment.NewLine +  Environment.NewLine + email_con.Text, fnameRegFont, brush, rightX + e.Graphics.MeasureString(emailBold, fnameBoldFont).Width, rightY);
         


            // Draw the information on the printing page

            // Draw more information as needed
        }


        public void loadData()
        {
            string ConString = "datasource=localhost;username=root;password=654321";
            string Query = "SELECT * FROM employees.userdata";
            MySqlConnection conn = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            MySqlDataReader myReader;
            //DataTable dt = new DataTable();
            //da.Fill(dt);

         //   dt.Columns.Add("table_img", Type.GetType("System.Byte[]"));

          /* foreach (DataRow row in dt.Rows)
            {

                row["table_img"] = File.ReadAllBytes(Application.StartupPath + @"\Image\" + Path.GetFileName(row["IMAGE"].ToString()));
            }
            dataGridView1.DataSource = dt;  */

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string image = myReader.GetString("IMAGE");
                    string fname = myReader.GetString("first_name");
                    string lname = myReader.GetString("last_name");
                    string department = myReader.GetString("Department");
                    string email = myReader.GetString("email");
                    string gender = myReader.GetString("gender");
                    string id = myReader.GetString("id");
                    int salary = myReader.GetInt32("salary");

                    MessageBox.Show("id : " + id + "firstname : " + fname +  "lastname : " + lname +  "department : " + department + "email : "+ email +  "gender : "+ gender + " salary : " + salary);


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
        private void Read_Data_Click(object sender, EventArgs e)
        {
           dataGridView1.Rows.Clear();
           dataGridView1.Refresh();
          
            loadData();
           


         }

        private void ViewEmployeesData_Load(object sender, EventArgs e)
        {

        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {

                string ConString = "datasource=localhost;username=root;password=654321";
                string Query = "UPDATE employees.userdata SET first_name = '" + fname_con.Text + "', last_name = '" + lname_con.Text + "', Department = '" + department_con.Text + "', gender = '" + gender_con.Text + "', email = '" + email_con.Text + "' WHERE id = '" + id_con.Text + "'";
                MySqlConnection conn = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(Query, conn);
                MySqlDataReader myReader;

                conn.Open();
                myReader = cmd.ExecuteReader();
                //dataGridView1.Rows.Clear();
                //dataGridView1.Refresh();
                loadData();

                MessageBox.Show("Successfully Update Employee information!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);


                conn.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("error while running: " + ex);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {


                Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();

                MExcel.Application.Workbooks.Add(Type.Missing);

                for(int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {

                    MExcel.Cells[1, i] = dataGridView1.Columns[i -1].HeaderText;
                }
                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for(int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        object cellValue = dataGridView1.Rows[i].Cells[j].Value;
                        string cellValueString = cellValue != null ? cellValue.ToString() : string.Empty;
                        MExcel.Cells[i + 2, j + 1] = cellValueString;

                    }
                }

                MExcel.Columns.AutoFit();
                MExcel.Rows.AutoFit();
                MExcel.Columns.Font.Size = 15;
                MExcel.Visible = true;
            }
            else
            {

                MessageBox.Show("No records found!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            home home = new home();

            home.Show();
            this.Close();
        }

        public string fnameValue
        {
            get { return fname_con.Text; }
        }
        public string lnameValue
        {
            get { return lname_con.Text; }
        }
        public string departmentValue
        {
            get { return department_con.Text; }
        }
        public string emailValue
        {
            get { return email_con.Text; }
        }
        public string genderValue
        {
            get { return gender_con.Text; }
        }
        public string idValue
        {
            get { return id_con.Text; }
        }
        public string salaryValue
        {
            get { return salary_con.Text; }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Print the document
                printDocument.Print();
            }



            string  fnameVal = fnameValue; // Get value from TextBox1
            string lnameVal = lnameValue; // Get value from TextBox2
            string departmentVal = departmentValue; // Get value from TextBox3
            string emailVal = emailValue;
            string genderVal = genderValue;
            string idVal = idValue;
            string salaryval = salaryValue;

            //PrintData pd = new PrintData(fnameVal , lnameVal, departmentVal, emailVal, genderVal , idVal , salaryval);

            

        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
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
    }
}
