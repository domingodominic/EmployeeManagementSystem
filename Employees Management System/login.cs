using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using MySql.Data.MySqlClient;
namespace Employees_Management_System
{
    public partial class login : Form
    {


        
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
           /* PrivateFontCollection pfc = new PrivateFontCollection();

            pfc.AddFontFile(@"C:\Poppins-SemiBold.ttf");

            foreach(Control c  in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 10, FontStyle.Bold);
            }
           */
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ConString = "datasource=localhost;username=root;password=654321";
            string Query = "SELECT * FROM employees.userdata WHERE username = '"+ usernameTx.Text +"' AND  password = '"+ PasswordTx.Text+"'";
            MySqlConnection conn = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            MySqlDataReader myReader;

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string username = myReader.GetString("username");
                    string password = myReader.GetString("password");
                    string firstname = myReader.GetString("first_name");
                    string lastname = myReader.GetString("last_name");

                    Program.lastname = lastname;
                    Program.firstname = firstname;

                        int roleId =  Convert.ToInt32( myReader.GetString("roleID"));

                        if(roleId == 1)
                        {

                            MessageBox.Show("Log in Successful");

                     

                       home hm = new home();

                       hm.Show();
                      
                            this.Close();




                        }
                        else if(roleId == 2)
                        {
                        users us = new users();

                        us.Show();

                        this.Close();
                        }
                   

                       // home hm = new home();

                      //  hm.Show();
                        //this.Hide();

                    
                    else
                    {

                        MessageBox.Show("Please input valid username and password");
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error while connecting: " + ex);
            }

            conn.Close();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            usernameTx.Clear();
            PasswordTx.Clear();
        
        
        }
        public static int parentX, parentY;
        private void changePass_Click(object sender, EventArgs e)
        {
            Form login = new Form();
            using (changepassword cp = new changepassword())
            {
                login.StartPosition = FormStartPosition.Manual;
                login.FormBorderStyle = FormBorderStyle.None;
                login.Opacity = .50d;
                login.BackColor = Color.Black;
                login.Size = this.Size;
                login.Location = this.Location;
                login.ShowInTaskbar = false;
                login.Show();
                cp.Owner = login;


                parentX = this.Location.X;
                parentY = this.Location.Y;
                cp.ShowDialog();
                login.Dispose();

            }



        }
    }
}
