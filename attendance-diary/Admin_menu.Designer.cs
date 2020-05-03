namespace attendance_diary
{
    partial class Admin_menu
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
            this.Btn_shift = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_shift
            // 
            this.Btn_shift.Location = new System.Drawing.Point(13, 13);
            this.Btn_shift.Name = "Btn_shift";
            this.Btn_shift.Size = new System.Drawing.Size(130, 23);
            this.Btn_shift.TabIndex = 0;
            this.Btn_shift.Text = "Dodaj prisotnost";
            this.Btn_shift.UseVisualStyleBackColor = true;
            this.Btn_shift.Click += new System.EventHandler(this.Btn_shift_Click);
            // 
            // Admin_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_shift);
            this.Name = "Admin_menu";
            this.Text = "Admin_menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_shift;
    }
}