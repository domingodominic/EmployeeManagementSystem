
namespace Employees_Management_System
{
    partial class ViewEmployeesData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Read_Data = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fname_con = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lname_con = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.department_con = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email_con = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gender_con = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.id_con = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.salary_con = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.homeBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Table_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Read_Data
            // 
            this.Read_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(225)))));
            this.Read_Data.Font = new System.Drawing.Font("Nexa Slab Bold FREE", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Read_Data.ForeColor = System.Drawing.Color.White;
            this.Read_Data.Location = new System.Drawing.Point(755, 250);
            this.Read_Data.Name = "Read_Data";
            this.Read_Data.Size = new System.Drawing.Size(110, 59);
            this.Read_Data.TabIndex = 0;
            this.Read_Data.Text = "VIEW";
            this.Read_Data.UseVisualStyleBackColor = false;
            this.Read_Data.Click += new System.EventHandler(this.Read_Data_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "FIRSTNAME";
            // 
            // fname_con
            // 
            this.fname_con.Location = new System.Drawing.Point(156, 8);
            this.fname_con.Multiline = true;
            this.fname_con.Name = "fname_con";
            this.fname_con.Size = new System.Drawing.Size(203, 40);
            this.fname_con.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(225)))));
            this.label2.Location = new System.Drawing.Point(34, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "LAST NAME";
            // 
            // lname_con
            // 
            this.lname_con.Location = new System.Drawing.Point(156, 59);
            this.lname_con.Multiline = true;
            this.lname_con.Name = "lname_con";
            this.lname_con.Size = new System.Drawing.Size(203, 40);
            this.lname_con.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(225)))));
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "DEPARTMENT";
            // 
            // department_con
            // 
            this.department_con.Location = new System.Drawing.Point(156, 116);
            this.department_con.Multiline = true;
            this.department_con.Name = "department_con";
            this.department_con.Size = new System.Drawing.Size(203, 40);
            this.department_con.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(225)))));
            this.label4.Location = new System.Drawing.Point(396, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "EMAIL";
            // 
            // email_con
            // 
            this.email_con.Location = new System.Drawing.Point(473, 8);
            this.email_con.Multiline = true;
            this.email_con.Name = "email_con";
            this.email_con.Size = new System.Drawing.Size(203, 40);
            this.email_con.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(225)))));
            this.label5.Location = new System.Drawing.Point(378, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "GENDER";
            // 
            // gender_con
            // 
            this.gender_con.Location = new System.Drawing.Point(473, 65);
            this.gender_con.Multiline = true;
            this.gender_con.Name = "gender_con";
            this.gender_con.Size = new System.Drawing.Size(203, 40);
            this.gender_con.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(225)))));
            this.label6.Location = new System.Drawing.Point(410, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID";
            // 
            // id_con
            // 
            this.id_con.Location = new System.Drawing.Point(473, 123);
            this.id_con.Multiline = true;
            this.id_con.Name = "id_con";
            this.id_con.Size = new System.Drawing.Size(203, 40);
            this.id_con.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(225)))));
            this.label7.Location = new System.Drawing.Point(34, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "SALARY";
            // 
            // salary_con
            // 
            this.salary_con.Location = new System.Drawing.Point(156, 168);
            this.salary_con.Multiline = true;
            this.salary_con.Name = "salary_con";
            this.salary_con.Size = new System.Drawing.Size(203, 40);
            this.salary_con.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(225)))));
            this.label8.Location = new System.Drawing.Point(32, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "INCOME TAX: 20%";
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(225)))));
            this.homeBtn.Font = new System.Drawing.Font("Nexa Slab Bold FREE", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Location = new System.Drawing.Point(523, 250);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(110, 59);
            this.homeBtn.TabIndex = 19;
            this.homeBtn.Text = "HOME";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nexa Slab Bold FREE", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Table_Id,
            this.table_fname,
            this.table_lname,
            this.table_email,
            this.Table_gender,
            this.table_Department,
            this.table_salary});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(13, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersWidth = 70;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 362);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged_1);
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
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(225)))));
            this.btnPrint.Font = new System.Drawing.Font("Nexa Slab Bold FREE", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::Employees_Management_System.Properties.Resources.Vector__4_;
            this.btnPrint.Location = new System.Drawing.Point(638, 250);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(110, 59);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(225)))));
            this.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(225)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Image = global::Employees_Management_System.Properties.Resources.solar_export_bold;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(876, 250);
            this.btnExport.Name = "btnExport";
            this.btnExport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExport.Size = new System.Drawing.Size(195, 59);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "EXPORT TO EXCEL";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ViewEmployeesData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 701);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.salary_con);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.id_con);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gender_con);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.email_con);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.department_con);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lname_con);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fname_con);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Read_Data);
            this.Name = "ViewEmployeesData";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Text = "ViewEmployeesData";
            this.Load += new System.EventHandler(this.ViewEmployeesData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Read_Data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fname_con;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lname_con;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox department_con;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email_con;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gender_con;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox id_con;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox salary_con;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_salary;
    }
}