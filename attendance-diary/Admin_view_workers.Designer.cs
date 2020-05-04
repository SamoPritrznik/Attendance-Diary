namespace attendance_diary
{
    partial class Admin_view_workers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_export = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_workers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(775, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // Btn_export
            // 
            this.Btn_export.Location = new System.Drawing.Point(160, 475);
            this.Btn_export.Name = "Btn_export";
            this.Btn_export.Size = new System.Drawing.Size(112, 23);
            this.Btn_export.TabIndex = 1;
            this.Btn_export.Text = "Izvozi v excel";
            this.Btn_export.UseVisualStyleBackColor = true;
            this.Btn_export.Click += new System.EventHandler(this.Btn_export_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Izberi delavca";
            // 
            // Cmb_workers
            // 
            this.Cmb_workers.FormattingEnabled = true;
            this.Cmb_workers.Location = new System.Drawing.Point(13, 477);
            this.Cmb_workers.Name = "Cmb_workers";
            this.Cmb_workers.Size = new System.Drawing.Size(121, 21);
            this.Cmb_workers.TabIndex = 5;
            this.Cmb_workers.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Admin_view_workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.Cmb_workers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_export);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin_view_workers";
            this.Text = "Admin_view_workers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_export;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_workers;
    }
}