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
            this.Btn_admin_creation = new System.Windows.Forms.Button();
            this.Btn_add_worker = new System.Windows.Forms.Button();
            this.Btn_add_constructions = new System.Windows.Forms.Button();
            this.Btn_export_workers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_shift
            // 
            this.Btn_shift.Location = new System.Drawing.Point(13, 112);
            this.Btn_shift.Name = "Btn_shift";
            this.Btn_shift.Size = new System.Drawing.Size(271, 23);
            this.Btn_shift.TabIndex = 0;
            this.Btn_shift.Text = "Dodaj prisotnost";
            this.Btn_shift.UseVisualStyleBackColor = true;
            this.Btn_shift.Click += new System.EventHandler(this.Btn_shift_Click);
            // 
            // Btn_admin_creation
            // 
            this.Btn_admin_creation.Location = new System.Drawing.Point(13, 187);
            this.Btn_admin_creation.Name = "Btn_admin_creation";
            this.Btn_admin_creation.Size = new System.Drawing.Size(271, 23);
            this.Btn_admin_creation.TabIndex = 1;
            this.Btn_admin_creation.Text = "Dodaj/Uredi admina";
            this.Btn_admin_creation.UseVisualStyleBackColor = true;
            this.Btn_admin_creation.Click += new System.EventHandler(this.Btn_admin_creation_Click);
            // 
            // Btn_add_worker
            // 
            this.Btn_add_worker.Location = new System.Drawing.Point(13, 42);
            this.Btn_add_worker.Name = "Btn_add_worker";
            this.Btn_add_worker.Size = new System.Drawing.Size(271, 23);
            this.Btn_add_worker.TabIndex = 2;
            this.Btn_add_worker.Text = "Dodaj/Uredi Delavca";
            this.Btn_add_worker.UseVisualStyleBackColor = true;
            this.Btn_add_worker.Click += new System.EventHandler(this.Btn_add_worker_Click);
            // 
            // Btn_add_constructions
            // 
            this.Btn_add_constructions.Location = new System.Drawing.Point(13, 256);
            this.Btn_add_constructions.Name = "Btn_add_constructions";
            this.Btn_add_constructions.Size = new System.Drawing.Size(271, 23);
            this.Btn_add_constructions.TabIndex = 3;
            this.Btn_add_constructions.Text = "Dodaj/Uredi gradbišče";
            this.Btn_add_constructions.UseVisualStyleBackColor = true;
            this.Btn_add_constructions.Click += new System.EventHandler(this.Btn_add_constructions_Click);
            // 
            // Btn_export_workers
            // 
            this.Btn_export_workers.Location = new System.Drawing.Point(13, 316);
            this.Btn_export_workers.Name = "Btn_export_workers";
            this.Btn_export_workers.Size = new System.Drawing.Size(271, 23);
            this.Btn_export_workers.TabIndex = 4;
            this.Btn_export_workers.Text = "Pogled delavcev";
            this.Btn_export_workers.UseVisualStyleBackColor = true;
            this.Btn_export_workers.Click += new System.EventHandler(this.Btn_export_workers_Click);
            // 
            // Admin_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 450);
            this.Controls.Add(this.Btn_export_workers);
            this.Controls.Add(this.Btn_add_constructions);
            this.Controls.Add(this.Btn_add_worker);
            this.Controls.Add(this.Btn_admin_creation);
            this.Controls.Add(this.Btn_shift);
            this.Name = "Admin_menu";
            this.Text = "Admin_menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_shift;
        private System.Windows.Forms.Button Btn_admin_creation;
        private System.Windows.Forms.Button Btn_add_worker;
        private System.Windows.Forms.Button Btn_add_constructions;
        private System.Windows.Forms.Button Btn_export_workers;
    }
}