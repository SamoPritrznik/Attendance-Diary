namespace attendance_diary
{
    partial class Admin_view_construction
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
            this.Cmb_constructions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_export = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date_begin_interval = new System.Windows.Forms.DateTimePicker();
            this.Date_end_interval = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cmb_constructions
            // 
            this.Cmb_constructions.FormattingEnabled = true;
            this.Cmb_constructions.Location = new System.Drawing.Point(12, 474);
            this.Cmb_constructions.Name = "Cmb_constructions";
            this.Cmb_constructions.Size = new System.Drawing.Size(121, 21);
            this.Cmb_constructions.TabIndex = 9;
            this.Cmb_constructions.SelectedIndexChanged += new System.EventHandler(this.Cmb_constructions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Izberi gradbišče";
            // 
            // Btn_export
            // 
            this.Btn_export.Location = new System.Drawing.Point(595, 472);
            this.Btn_export.Name = "Btn_export";
            this.Btn_export.Size = new System.Drawing.Size(112, 23);
            this.Btn_export.TabIndex = 7;
            this.Btn_export.Text = "Izvozi v excel";
            this.Btn_export.UseVisualStyleBackColor = true;
            this.Btn_export.Click += new System.EventHandler(this.Btn_export_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(775, 425);
            this.dataGridView1.TabIndex = 6;
            // 
            // Date_begin_interval
            // 
            this.Date_begin_interval.Location = new System.Drawing.Point(151, 474);
            this.Date_begin_interval.MaxDate = new System.DateTime(2020, 5, 4, 0, 0, 0, 0);
            this.Date_begin_interval.MinDate = new System.DateTime(1999, 12, 31, 0, 0, 0, 0);
            this.Date_begin_interval.Name = "Date_begin_interval";
            this.Date_begin_interval.Size = new System.Drawing.Size(200, 20);
            this.Date_begin_interval.TabIndex = 10;
            this.Date_begin_interval.Value = new System.DateTime(2020, 5, 4, 0, 0, 0, 0);
            // 
            // Date_end_interval
            // 
            this.Date_end_interval.Location = new System.Drawing.Point(357, 474);
            this.Date_end_interval.MaxDate = new System.DateTime(2020, 5, 4, 0, 0, 0, 0);
            this.Date_end_interval.MinDate = new System.DateTime(1999, 12, 31, 0, 0, 0, 0);
            this.Date_end_interval.Name = "Date_end_interval";
            this.Date_end_interval.Size = new System.Drawing.Size(200, 20);
            this.Date_end_interval.TabIndex = 11;
            this.Date_end_interval.Value = new System.DateTime(2020, 5, 4, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Izberi začetek intervala";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Izberi konec intervala";
            // 
            // Admin_view_construction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Date_end_interval);
            this.Controls.Add(this.Date_begin_interval);
            this.Controls.Add(this.Cmb_constructions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_export);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin_view_construction";
            this.Text = "Admin_view_construction";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cmb_constructions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_export;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker Date_begin_interval;
        private System.Windows.Forms.DateTimePicker Date_end_interval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}