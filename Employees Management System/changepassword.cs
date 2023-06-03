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
    public partial class changepassword : Form
    {
        public changepassword()
        {
            InitializeComponent();
        }
        string username, password;
        public void loadData()
        {
            
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string ConString = "datasource=localhost;username=root;password=654321";
            string Query = "SELECT * FROM employees.admin";
            MySqlConnection conn = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            MySqlDataReader myReader;
          

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                     username = myReader.GetString("username");
                    password = myReader.GetString("password");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error while connecting: " + ex);
            }

            conn.Close();



            if (oldPass_tx.Text == password)
            {

                try
                {

                    string ConStrings = "datasource=localhost;username=root;password=654321";
                    string Querys = "UPDATE employees.admin SET password = '" + newPass_tx.Text + "'";
                    MySqlConnection conns = new MySqlConnection(ConStrings);
                    MySqlCommand cmds = new MySqlCommand(Querys, conns);
                    MySqlDataReader myReaders;

                    conns.Open();
                    myReaders = cmds.ExecuteReader();
                    loadData();

                    MessageBox.Show("Successfully Update Employee information!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    conns.Close();


                }
                catch (Exception ex)
                {

                    MessageBox.Show("error while running: " + ex);
                }
            }
            else
            {
                MessageBox.Show("Invalid");
            }



        }
        int i;
        private void changepassword_Load(object sender, EventArgs e)
        {

            loadData();
            i = login.parentY + 150;
            this.Location = new Point(login.parentX + 160, login.parentY + 100);
            changepassword cp = new changepassword();

            cp.Size = new Size(100,100);
        }

        private void modalTimer_Tick(object sender, EventArgs e)


        {

          /*  changepassword cp = new changepassword();

            int width = 0;
            int height = 0;
            height++;
            width++;


           

            if (width == 1117 && height == 757)
            {

                cp.Size = new Size(width, height);
                modalTimer.Stop();
            }
          */




            /*         if(Opacity >= 1)
                 {

                     modalTimer.Stop();
                 }
                 else
                 {
                     Opacity += .03;
                 }
                 int y = login.parentY += 3;
                 this.Location = new Point(login.parentX + 220, y);
                 if(y >= i)
                 {

                     modalTimer.Stop();
                 }
             } */
        }
    }
}
