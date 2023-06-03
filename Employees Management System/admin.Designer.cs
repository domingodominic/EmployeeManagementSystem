
namespace Employees_Management_System
{
    partial class admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fname_con = new System.Windows.Forms.Label();
            this.lname_con = new System.Windows.Forms.Label();
            this.accept_btn = new System.Windows.Forms.Button();
            this.decline_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.table_firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fname_txt = new System.Windows.Forms.TextBox();
            this.lname_txt = new System.Windows.Forms.TextBox();
            this.status_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nexa Slab Bold FREE", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "PANG ADMIN LANG ITOOO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nexa Slab Bold FREE", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "WELCOME!";
            // 
            // fname_con
            // 
            this.fname_con.AutoSize = true;
            this.fname_con.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_con.Location = new System.Drawing.Point(206, 40);
            this.fname_con.Name = "fname_con";
            this.fname_con.Size = new System.Drawing.Size(64, 25);
            this.fname_con.TabIndex = 2;
            this.fname_con.Text = "label3";
            // 
            // lname_con
            // 
            this.lname_con.AutoSize = true;
            this.lname_con.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_con.Location = new System.Drawing.Point(281, 42);
            this.lname_con.Name = "lname_con";
            this.lname_con.Size = new System.Drawing.Size(64, 25);
            this.lname_con.TabIndex = 3;
            this.lname_con.Text = "label3";
            // 
            // accept_btn
            // 
            this.accept_btn.Location = new System.Drawing.Point(845, 135);
            this.accept_btn.Name = "accept_btn";
            this.accept_btn.Size = new System.Drawing.Size(81, 43);
            this.accept_btn.TabIndex = 5;
            this.accept_btn.Text = "ACCEPT";
            this.accept_btn.UseVisualStyleBackColor = true;
            this.accept_btn.Click += new System.EventHandler(this.accept_btn_Click);
            // 
            // decline_btn
            // 
            this.decline_btn.Location = new System.Drawing.Point(943, 135);
            this.decline_btn.Name = "decline_btn";
            this.decline_btn.Size = new System.Drawing.Size(92, 43);
            this.decline_btn.TabIndex = 6;
            this.decline_btn.Text = "DECLINE";
            this.decline_btn.UseVisualStyleBackColor = true;
            this.decline_btn.Click += new System.EventHandler(this.decline_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(943, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = "LOG OUT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.table_firstname,
            this.table_lastname,
            this.table_status});
            this.dataGridView1.Location = new System.Drawing.Point(48, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(638, 216);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // table_firstname
            // 
            this.table_firstname.HeaderText = "First Name";
            this.table_firstname.MinimumWidth = 8;
            this.table_firstname.Name = "table_firstname";
            this.table_firstname.ReadOnly = true;
            this.table_firstname.Width = 150;
            // 
            // table_lastname
            // 
            this.table_lastname.HeaderText = "Last Name";
            this.table_lastname.MinimumWidth = 8;
            this.table_lastname.Name = "table_lastname";
            this.table_lastname.ReadOnly = true;
            this.table_lastname.Width = 150;
            // 
            // table_status
            // 
            this.table_status.HeaderText = "Status";
            this.table_status.MinimumWidth = 8;
            this.table_status.Name = "table_status";
            this.table_status.ReadOnly = true;
            this.table_status.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "FIRSTNAME :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "LASTNAME :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "STATUS :";
            // 
            // fname_txt
            // 
            this.fname_txt.Location = new System.Drawing.Point(180, 397);
            this.fname_txt.Name = "fname_txt";
            this.fname_txt.Size = new System.Drawing.Size(165, 26);
            this.fname_txt.TabIndex = 14;
            // 
            // lname_txt
            // 
            this.lname_txt.Location = new System.Drawing.Point(180, 437);
            this.lname_txt.Name = "lname_txt";
            this.lname_txt.Size = new System.Drawing.Size(165, 26);
            this.lname_txt.TabIndex = 15;
            // 
            // status_txt
            // 
            this.status_txt.Location = new System.Drawing.Point(180, 481);
            this.status_txt.Name = "status_txt";
            this.status_txt.Size = new System.Drawing.Size(165, 26);
            this.status_txt.TabIndex = 16;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 701);
            this.Controls.Add(this.status_txt);
            this.Controls.Add(this.lname_txt);
            this.Controls.Add(this.fname_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.decline_btn);
            this.Controls.Add(this.accept_btn);
            this.Controls.Add(this.lname_con);
            this.Controls.Add(this.fname_con);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fname_con;
        private System.Windows.Forms.Label lname_con;
        private System.Windows.Forms.Button accept_btn;
        private System.Windows.Forms.Button decline_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fname_txt;
        private System.Windows.Forms.TextBox lname_txt;
        private System.Windows.Forms.TextBox status_txt;
    }
}