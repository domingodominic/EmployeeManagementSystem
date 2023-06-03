
namespace Employees_Management_System
{
    partial class changepassword
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
            this.components = new System.ComponentModel.Container();
            this.update_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oldPass_tx = new System.Windows.Forms.TextBox();
            this.newPass_tx = new System.Windows.Forms.TextBox();
            this.modalTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(351, 215);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(125, 47);
            this.update_btn.TabIndex = 0;
            this.update_btn.Text = "UPDATE";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Old password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "new password";
            // 
            // oldPass_tx
            // 
            this.oldPass_tx.Location = new System.Drawing.Point(309, 129);
            this.oldPass_tx.Name = "oldPass_tx";
            this.oldPass_tx.Size = new System.Drawing.Size(167, 26);
            this.oldPass_tx.TabIndex = 3;
            // 
            // newPass_tx
            // 
            this.newPass_tx.Location = new System.Drawing.Point(309, 167);
            this.newPass_tx.Name = "newPass_tx";
            this.newPass_tx.Size = new System.Drawing.Size(167, 26);
            this.newPass_tx.TabIndex = 4;
            // 
            // modalTimer
            // 
            this.modalTimer.Enabled = true;
            this.modalTimer.Interval = 1;
            this.modalTimer.Tick += new System.EventHandler(this.modalTimer_Tick);
            // 
            // changepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 469);
            this.Controls.Add(this.newPass_tx);
            this.Controls.Add(this.oldPass_tx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update_btn);
            this.Name = "changepassword";
            this.Text = "changepassword";
            this.Load += new System.EventHandler(this.changepassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oldPass_tx;
        private System.Windows.Forms.TextBox newPass_tx;
        private System.Windows.Forms.Timer modalTimer;
    }
}