
namespace Employees_Management_System
{
    partial class users
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
            this.fname_lb = new System.Windows.Forms.Label();
            this.lname_lb = new System.Windows.Forms.Label();
            this.reqBtn = new System.Windows.Forms.Button();
            this.status_lb = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nexa Slab Bold FREE", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            // 
            // fname_lb
            // 
            this.fname_lb.AutoSize = true;
            this.fname_lb.Location = new System.Drawing.Point(151, 13);
            this.fname_lb.Name = "fname_lb";
            this.fname_lb.Size = new System.Drawing.Size(106, 20);
            this.fname_lb.TabIndex = 1;
            this.fname_lb.Text = "FIRST NAME";
            // 
            // lname_lb
            // 
            this.lname_lb.AutoSize = true;
            this.lname_lb.Location = new System.Drawing.Point(291, 14);
            this.lname_lb.Name = "lname_lb";
            this.lname_lb.Size = new System.Drawing.Size(99, 20);
            this.lname_lb.TabIndex = 2;
            this.lname_lb.Text = "LAST NAME";
            // 
            // reqBtn
            // 
            this.reqBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(225)))));
            this.reqBtn.ForeColor = System.Drawing.Color.White;
            this.reqBtn.Location = new System.Drawing.Point(45, 307);
            this.reqBtn.Name = "reqBtn";
            this.reqBtn.Size = new System.Drawing.Size(203, 52);
            this.reqBtn.TabIndex = 3;
            this.reqBtn.Text = "REQUEST LEAVE";
            this.reqBtn.UseVisualStyleBackColor = false;
            this.reqBtn.Click += new System.EventHandler(this.reqBtn_Click);
            // 
            // status_lb
            // 
            this.status_lb.AutoSize = true;
            this.status_lb.Location = new System.Drawing.Point(254, 323);
            this.status_lb.Name = "status_lb";
            this.status_lb.Size = new System.Drawing.Size(254, 20);
            this.status_lb.TabIndex = 4;
            this.status_lb.Text = "you request status will appear here";
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Red;
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(45, 365);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(203, 52);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.Text = "LOG OUT ";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.status_lb);
            this.Controls.Add(this.reqBtn);
            this.Controls.Add(this.lname_lb);
            this.Controls.Add(this.fname_lb);
            this.Controls.Add(this.label1);
            this.Name = "users";
            this.Text = "users";
            this.Load += new System.EventHandler(this.users_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fname_lb;
        private System.Windows.Forms.Label lname_lb;
        private System.Windows.Forms.Button reqBtn;
        private System.Windows.Forms.Label status_lb;
        private System.Windows.Forms.Button logout_btn;
    }
}