namespace attendance_diary
{
    partial class Meni
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
            this.Btn_login = new System.Windows.Forms.Button();
            this.Btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_login
            // 
            this.Btn_login.Location = new System.Drawing.Point(42, 28);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(201, 28);
            this.Btn_login.TabIndex = 0;
            this.Btn_login.Text = "Vpis";
            this.Btn_login.UseVisualStyleBackColor = true;
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // Btn_close
            // 
            this.Btn_close.Location = new System.Drawing.Point(42, 74);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(201, 28);
            this.Btn_close.TabIndex = 1;
            this.Btn_close.Text = "Zapri";
            this.Btn_close.UseVisualStyleBackColor = true;
            this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // Meni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 134);
            this.Controls.Add(this.Btn_close);
            this.Controls.Add(this.Btn_login);
            this.Name = "Meni";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_login;
        private System.Windows.Forms.Button Btn_close;
    }
}

