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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            string ConString = "datasource=localhost;username=root;password=654321";
            string Query = "SELECT * FROM employees.leaveRequest";
            MySqlConnection conn = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            MySqlDataReader myReader;
         

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string firstname = myReader.GetString("firstname");
                    string lastname = myReader.GetString("lastname");
                    string status = myReader.GetString("status");
                    Program.status = status;


                  
                    dataGridView1.Rows.Add(firstname , lastname , status);
                   
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error while connecting: " + ex);
            }

            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {



                string fnameValue = row.Cells[0].Value.ToString();
                string lnameValue = row.Cells[1].Value.ToString();
                string statusValue = row.Cells[2].Value.ToString();

                fname_txt.Text = fnameValue;
                lname_txt.Text = lnameValue;
                status_txt.Text = statusValue;
                
            }

        }

        private void accept_btn_Click(object sender, EventArgs e)
        {
            try
            {

                string ConString = "datasource=localhost;username=root;password=654321";
                string Query = "UPDATE employees.leaveRequest SET status =  '" + "Accepted" +"' WHERE firstname = '" + fname_txt.Text +"' AND lastname = '" + lname_txt.Text +"'" ;
                MySqlConnection conn = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(Query, conn);
                MySqlDataReader myReader;

                conn.Open();
                myReader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                loadData();
                conn.Close();


                DialogResult dialogresult = MessageBox.Show("Are you sure you want to accept the request?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogresult == DialogResult.Yes)
                {

                    string delQuery = "DELETE FROM employees.leaveRequest WHERE firstname = '" + fname_txt.Text + "'  AND lastname = '" + lname_txt.Text + "'";
                    string ConStrings = "datasource=localhost;username=root;password=654321";
                    MySqlConnection conns = new MySqlConnection(ConStrings);
                    MySqlCommand cmds = new MySqlCommand(delQuery, conns);
                    MySqlDataReader myReaders;

                    conns.Open();
                    myReaders = cmds.ExecuteReader();

                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    loadData();

                }

                conn.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("error while running: " + ex);
            }
        }

        private void decline_btn_Click(object sender, EventArgs e)
        {

            try
            {

                string ConString = "datasource=localhost;username=root;password=654321";
                string Query = "UPDATE employees.leaveRequest SET status =  '" + "Declined" + "' ";
                MySqlConnection conn = new MySqlConnection(ConString);
                MySqlCommand cmd = new MySqlCommand(Query, conn);
                MySqlDataReader myReader;

                conn.Open();
                myReader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                loadData();

            DialogResult dialogresult = MessageBox.Show("Are you sure you want to declined the request?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogresult == DialogResult.Yes)
                {

                    string delQuery = "DELETE FROM employees.leaveRequest WHERE firstname = '" + fname_txt.Text + "'  AND lastname = '" + lname_txt.Text + "'";
                    string ConStrings = "datasource=localhost;username=root;password=654321";
                    MySqlConnection conns = new MySqlConnection(ConStrings);
                    MySqlCommand cmds = new MySqlCommand(delQuery, conns);
                    MySqlDataReader myReaders;

                    conns.Open();
                    myReaders = cmds.ExecuteReader();

                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    loadData();

                }

                conn.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("error while running: " + ex);
            }

        }
    }
}
