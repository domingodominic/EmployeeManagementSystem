
namespace Employees_Management_System
{
    partial class update
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Table_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_btn = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.id_con = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gender_con = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email_con = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lname_con = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fname_con = new System.Windows.Forms.TextBox();
            this.department_con = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.salary_con = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nexa Slab Bold FREE", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Table_Id,
            this.table_fname,
            this.table_lname,
            this.table_email,
            this.Table_gender,
            this.table_Department,
            this.table_salary});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 70;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 362);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // table_salary
            // 
            this.table_salary.HeaderText = "Salary";
            this.table_salary.MinimumWidth = 8;
            this.table_salary.Name = "table_salary";
            this.table_salary.ReadOnly = true;
            this.table_salary.Width = 150;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(950, 268);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(111, 44);
            this.update_btn.TabIndex = 14;
            this.update_btn.Text = "UPDATE";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(753, 62);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(216, 57);
            this.txtSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(882, 125);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 37);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // id_con
            // 
            this.id_con.Location = new System.Drawing.Point(474, 110);
            this.id_con.Name = "id_con";
            this.id_con.Size = new System.Drawing.Size(156, 26);
            this.id_con.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID";
            // 
            // gender_con
            // 
            this.gender_con.Location = new System.Drawing.Point(474, 73);
            this.gender_con.Name = "gender_con";
            this.gender_con.Size = new System.Drawing.Size(156, 26);
            this.gender_con.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "GENDER";
            // 
            // email_con
            // 
            this.email_con.Location = new System.Drawing.Point(474, 30);
            this.email_con.Name = "email_con";
            this.email_con.Size = new System.Drawing.Size(156, 26);
            this.email_con.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "EMAIL";
            // 
            // lname_con
            // 
            this.lname_con.Location = new System.Drawing.Point(182, 74);
            this.lname_con.Name = "lname_con";
            this.lname_con.Size = new System.Drawing.Size(156, 26);
            this.lname_con.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "DEPARTMENT";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(60, 30);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(102, 20);
            this.fname.TabIndex = 0;
            this.fname.Text = "FIRSTNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "LASTNAME";
            // 
            // fname_con
            // 
            this.fname_con.Location = new System.Drawing.Point(182, 30);
            this.fname_con.Name = "fname_con";
            this.fname_con.Size = new System.Drawing.Size(156, 26);
            this.fname_con.TabIndex = 7;
            // 
            // department_con
            // 
            this.department_con.Location = new System.Drawing.Point(182, 113);
            this.department_con.Name = "department_con";
            this.department_con.Size = new System.Drawing.Size(156, 26);
            this.department_con.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "SALARY";
            // 
            // salary_con
            // 
            this.salary_con.Location = new System.Drawing.Point(182, 152);
            this.salary_con.Name = "salary_con";
            this.salary_con.Size = new System.Drawing.Size(156, 26);
            this.salary_con.TabIndex = 19;
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 701);
            this.Controls.Add(this.salary_con);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.id_con);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gender_con);
            this.Controls.Add(this.email_con);
            this.Controls.Add(this.department_con);
            this.Controls.Add(this.lname_con);
            this.Controls.Add(this.fname_con);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fname);
            this.Name = "update";
            this.Text = "update";
            this.Load += new System.EventHandler(this.update_Load);
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
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox id_con;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gender_con;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email_con;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lname_con;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fname_con;
        private System.Windows.Forms.TextBox department_con;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox salary_con;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_salary;
    }
}