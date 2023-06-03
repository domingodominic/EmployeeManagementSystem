
namespace Employees_Management_System
{
    partial class Delete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Table_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fname_con = new System.Windows.Forms.TextBox();
            this.lname_con = new System.Windows.Forms.TextBox();
            this.department_con = new System.Windows.Forms.TextBox();
            this.email_con = new System.Windows.Forms.TextBox();
            this.gender_con = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.id_con = new System.Windows.Forms.TextBox();
            this.del_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.salary_con = new System.Windows.Forms.TextBox();
            this.table_salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(225)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Table_Id,
            this.table_fname,
            this.table_lname,
            this.table_email,
            this.Table_gender,
            this.table_Department,
            this.table_salary});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(28, 291);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 374);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Table_Id
            // 
            this.Table_Id.HeaderText = "Id";
            this.Table_Id.MinimumWidth = 8;
            this.Table_Id.Name = "Table_Id";
            this.Table_Id.ReadOnly = true;
            this.Table_Id.Width = 150;
            // 
            // table_fname
            // 
            this.table_fname.HeaderText = "First name";
            this.table_fname.MinimumWidth = 8;
            this.table_fname.Name = "table_fname";
            this.table_fname.ReadOnly = true;
            this.table_fname.Width = 150;
            // 
            // table_lname
            // 
            this.table_lname.HeaderText = "Last name";
            this.table_lname.MinimumWidth = 8;
            this.table_lname.Name = "table_lname";
            this.table_lname.ReadOnly = true;
            this.table_lname.Width = 150;
            // 
            // table_email
            // 
            this.table_email.HeaderText = "Email";
            this.table_email.MinimumWidth = 8;
            this.table_email.Name = "table_email";
            this.table_email.ReadOnly = true;
            this.table_email.Width = 150;
            // 
            // Table_gender
            // 
            this.Table_gender.HeaderText = "Gender";
            this.Table_gender.MinimumWidth = 8;
            this.Table_gender.Name = "Table_gender";
            this.Table_gender.ReadOnly = true;
            this.Table_gender.Width = 150;
            // 
            // table_Department
            // 
            this.table_Department.HeaderText = "Department";
            this.table_Department.MinimumWidth = 8;
            this.table_Department.Name = "table_Department";
            this.table_Department.ReadOnly = true;
            this.table_Department.Width = 150;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(913, 30);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(157, 27);
            this.txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(968, 63);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 38);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1098, 112);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 38);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nexa Slab Bold FREE", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "FIRSTNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nexa Slab Bold FREE", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "LASTNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nexa Slab Bold FREE", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "DEPARTMENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nexa Slab Bold FREE", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(467, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "EMAIL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nexa Slab Bold FREE", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "GENDER";
            // 
            // fname_con
            // 
            this.fname_con.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_con.Location = new System.Drawing.Point(158, 24);
            this.fname_con.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fname_con.Name = "fname_con";
            this.fname_con.Size = new System.Drawing.Size(240, 27);
            this.fname_con.TabIndex = 12;
            // 
            // lname_con
            // 
            this.lname_con.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_con.Location = new System.Drawing.Point(584, 24);
            this.lname_con.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lname_con.Name = "lname_con";
            this.lname_con.Size = new System.Drawing.Size(240, 27);
            this.lname_con.TabIndex = 13;
            // 
            // department_con
            // 
            this.department_con.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department_con.Location = new System.Drawing.Point(154, 79);
            this.department_con.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.department_con.Name = "department_con";
            this.department_con.Size = new System.Drawing.Size(240, 27);
            this.department_con.TabIndex = 14;
            // 
            // email_con
            // 
            this.email_con.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_con.Location = new System.Drawing.Point(584, 79);
            this.email_con.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.email_con.Name = "email_con";
            this.email_con.Size = new System.Drawing.Size(240, 27);
            this.email_con.TabIndex = 15;
            // 
            // gender_con
            // 
            this.gender_con.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_con.Location = new System.Drawing.Point(154, 129);
            this.gender_con.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gender_con.Name = "gender_con";
            this.gender_con.Size = new System.Drawing.Size(240, 27);
            this.gender_con.TabIndex = 16;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Nexa Slab Bold FREE", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(477, 131);
            this.id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(28, 19);
            this.id.TabIndex = 17;
            this.id.Text = "ID";
            // 
            // id_con
            // 
            this.id_con.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_con.Location = new System.Drawing.Point(584, 131);
            this.id_con.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.id_con.Name = "id_con";
            this.id_con.Size = new System.Drawing.Size(240, 27);
            this.id_con.TabIndex = 18;
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(225)))));
            this.del_btn.ForeColor = System.Drawing.Color.White;
            this.del_btn.Location = new System.Drawing.Point(958, 175);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(130, 67);
            this.del_btn.TabIndex = 19;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(225)))));
            this.home_btn.ForeColor = System.Drawing.Color.White;
            this.home_btn.Location = new System.Drawing.Point(822, 175);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(130, 67);
            this.home_btn.TabIndex = 20;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nexa Slab Bold FREE", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "SALARY";
            // 
            // salary_con
            // 
            this.salary_con.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_con.Location = new System.Drawing.Point(154, 182);
            this.salary_con.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.salary_con.Name = "salary_con";
            this.salary_con.Size = new System.Drawing.Size(240, 27);
            this.salary_con.TabIndex = 22;
            // 
            // table_salary
            // 
            this.table_salary.HeaderText = "Salary";
            this.table_salary.MinimumWidth = 8;
            this.table_salary.Name = "table_salary";
            this.table_salary.ReadOnly = true;
            this.table_salary.Width = 150;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 701);
            this.Controls.Add(this.salary_con);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.id_con);
            this.Controls.Add(this.id);
            this.Controls.Add(this.gender_con);
            this.Controls.Add(this.email_con);
            this.Controls.Add(this.department_con);
            this.Controls.Add(this.lname_con);
            this.Controls.Add(this.fname_con);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Nexa Slab Bold FREE", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_Department;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fname_con;
        private System.Windows.Forms.TextBox lname_con;
        private System.Windows.Forms.TextBox department_con;
        private System.Windows.Forms.TextBox email_con;
        private System.Windows.Forms.TextBox gender_con;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox id_con;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox salary_con;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_salary;
    }
}