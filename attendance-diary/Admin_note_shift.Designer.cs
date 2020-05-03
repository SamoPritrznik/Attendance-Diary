namespace attendance_diary
{
    partial class Admin_note_shift
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
            this.DateTimePickerShift = new System.Windows.Forms.DateTimePicker();
            this.CmbBx_worker = new System.Windows.Forms.ComboBox();
            this.CmbBx_construction = new System.Windows.Forms.ComboBox();
            this.Txt_minutes = new System.Windows.Forms.TextBox();
            this.Btn_addTime = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateTimePickerShift
            // 
            this.DateTimePickerShift.CustomFormat = "yyyy-MM-dd";
            this.DateTimePickerShift.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerShift.Location = new System.Drawing.Point(12, 34);
            this.DateTimePickerShift.MaxDate = new System.DateTime(2020, 5, 3, 17, 50, 52, 0);
            this.DateTimePickerShift.MinDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerShift.Name = "DateTimePickerShift";
            this.DateTimePickerShift.Size = new System.Drawing.Size(194, 20);
            this.DateTimePickerShift.TabIndex = 0;
            this.DateTimePickerShift.Value = new System.DateTime(2020, 5, 3, 0, 0, 0, 0);
            this.DateTimePickerShift.ValueChanged += new System.EventHandler(this.DateTimePickerShift_ValueChanged);
            // 
            // CmbBx_worker
            // 
            this.CmbBx_worker.FormattingEnabled = true;
            this.CmbBx_worker.Location = new System.Drawing.Point(12, 84);
            this.CmbBx_worker.Name = "CmbBx_worker";
            this.CmbBx_worker.Size = new System.Drawing.Size(121, 21);
            this.CmbBx_worker.TabIndex = 1;
            // 
            // CmbBx_construction
            // 
            this.CmbBx_construction.FormattingEnabled = true;
            this.CmbBx_construction.Location = new System.Drawing.Point(12, 135);
            this.CmbBx_construction.Name = "CmbBx_construction";
            this.CmbBx_construction.Size = new System.Drawing.Size(121, 21);
            this.CmbBx_construction.TabIndex = 2;
            // 
            // Txt_minutes
            // 
            this.Txt_minutes.Location = new System.Drawing.Point(12, 190);
            this.Txt_minutes.Name = "Txt_minutes";
            this.Txt_minutes.Size = new System.Drawing.Size(100, 20);
            this.Txt_minutes.TabIndex = 3;
            // 
            // Btn_addTime
            // 
            this.Btn_addTime.Location = new System.Drawing.Point(12, 216);
            this.Btn_addTime.Name = "Btn_addTime";
            this.Btn_addTime.Size = new System.Drawing.Size(75, 23);
            this.Btn_addTime.TabIndex = 4;
            this.Btn_addTime.Text = "Dodaj";
            this.Btn_addTime.UseVisualStyleBackColor = true;
            this.Btn_addTime.Click += new System.EventHandler(this.Btn_addTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Število opravljenih minut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ime in priimek delavca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ime gradbišča";
            // 
            // Admin_note_shift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 265);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_addTime);
            this.Controls.Add(this.Txt_minutes);
            this.Controls.Add(this.CmbBx_construction);
            this.Controls.Add(this.CmbBx_worker);
            this.Controls.Add(this.DateTimePickerShift);
            this.Name = "Admin_note_shift";
            this.Text = "Admin_note_shift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePickerShift;
        private System.Windows.Forms.ComboBox CmbBx_worker;
        private System.Windows.Forms.ComboBox CmbBx_construction;
        private System.Windows.Forms.TextBox Txt_minutes;
        private System.Windows.Forms.Button Btn_addTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}