namespace attendance_diary
{
    partial class Admin_login
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
            this.Email = new System.Windows.Forms.Label();
            this.Geslo = new System.Windows.Forms.Label();
            this.Txt_email = new System.Windows.Forms.TextBox();
            this.Txt_password = new System.Windows.Forms.TextBox();
            this.Btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(13, 13);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 0;
            this.Email.Text = "Email";
            // 
            // Geslo
            // 
            this.Geslo.AutoSize = true;
            this.Geslo.Location = new System.Drawing.Point(12, 75);
            this.Geslo.Name = "Geslo";
            this.Geslo.Size = new System.Drawing.Size(34, 13);
            this.Geslo.TabIndex = 1;
            this.Geslo.Text = "Geslo";
            // 
            // Txt_email
            // 
            this.Txt_email.Location = new System.Drawing.Point(13, 30);
            this.Txt_email.Name = "Txt_email";
            this.Txt_email.Size = new System.Drawing.Size(100, 20);
            this.Txt_email.TabIndex = 2;
            // 
            // Txt_password
            // 
            this.Txt_password.Location = new System.Drawing.Point(12, 91);
            this.Txt_password.Name = "Txt_password";
            this.Txt_password.PasswordChar = '*';
            this.Txt_password.Size = new System.Drawing.Size(100, 20);
            this.Txt_password.TabIndex = 3;
            // 
            // Btn_login
            // 
            this.Btn_login.Location = new System.Drawing.Point(12, 132);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(75, 23);
            this.Btn_login.TabIndex = 4;
            this.Btn_login.Text = "Prijava";
            this.Btn_login.UseVisualStyleBackColor = true;
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // Admin_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 191);
            this.Controls.Add(this.Btn_login);
            this.Controls.Add(this.Txt_password);
            this.Controls.Add(this.Txt_email);
            this.Controls.Add(this.Geslo);
            this.Controls.Add(this.Email);
            this.Name = "Admin_login";
            this.Text = "Admin_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Geslo;
        private System.Windows.Forms.TextBox Txt_email;
        private System.Windows.Forms.TextBox Txt_password;
        private System.Windows.Forms.Button Btn_login;
    }
}