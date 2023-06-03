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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void ReadData_Click(object sender, EventArgs e)
        {
            ViewEmployeesData ved = new ViewEmployeesData();

            ved.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployee AE = new AddEmployee();

            AE.Show();
            this.Hide();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            update UD = new update();

            UD.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete DEL = new Delete();

            DEL.Show();
            this.Hide();
        }

        private void request_btn_Click(object sender, EventArgs e)
        {
            admin ad = new admin();

            ad.Show();
            this.Hide();
        }
    }
}
