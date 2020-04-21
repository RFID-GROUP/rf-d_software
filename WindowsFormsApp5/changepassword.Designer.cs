namespace WindowsFormsApp5
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.newpass = new System.Windows.Forms.TextBox();
            this.confimpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Change Password";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // newpass
            // 
            this.newpass.Location = new System.Drawing.Point(94, 34);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(137, 20);
            this.newpass.TabIndex = 2;
            // 
            // confimpass
            // 
            this.confimpass.Location = new System.Drawing.Point(94, 93);
            this.confimpass.Name = "confimpass";
            this.confimpass.Size = new System.Drawing.Size(137, 20);
            this.confimpass.TabIndex = 3;
            // 
            // changepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 291);
            this.Controls.Add(this.confimpass);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "changepassword";
            this.Text = "changepassword";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.changepassword_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.changepassword_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.changepassword_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.TextBox confimpass;
    }
}