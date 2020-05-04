using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendance_diary
{
    public partial class Admin_view_workers : Form
    {
        DataTable dt = new DataTable();

        API_Controller api = new API_Controller();
        public Admin_view_workers()
        {
            InitializeComponent();

            dataGridView1.DataSource = dt;

            Cmb_workers.Items.AddRange(api.WorkersToCmb(api.getAllWorkers()).ToArray());
        }
        


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
            DataRow dr = dt.NewRow();

            string[] words = Cmb_workers.SelectedItem.ToString().Split(' ');
            string worker_name = words[0];
            string worker_surname = words[1];

            string worker_id = api.getWorkerId(api.getAllWorkers(), worker_name, worker_surname);

            List <Time> listek = api.returnListTime(api.getAllTime(), worker_id);

            for(int x = 0; x < listek.Count; x++)
            {
                if (dt.Rows.Count <= 0)
                {
                    if (listek[x].worker_id == worker_id)
                    {
                        DataColumn dc1 = new DataColumn("Ime", typeof(string));
                        DataColumn dc2 = new DataColumn("Priimek", typeof(string));
                        DataColumn dc3 = new DataColumn("Ime gradbišča", typeof(string));
                        DataColumn dc4 = new DataColumn("Datum", typeof(string));
                        DataColumn dc5 = new DataColumn("Število opravljenih minut", typeof(string));


                        dt.Columns.Add(dc1);
                        dt.Columns.Add(dc2);
                        dt.Columns.Add(dc3);
                        dt.Columns.Add(dc4);
                        dt.Columns.Add(dc5);



                        dt.Rows.Add(worker_name, worker_surname, api.getConstructionName(api.getAllConstructions(), listek[x].construction_id), listek[x].Timestamp_date, listek[x].Shift);


                        dataGridView1.DataSource = dt;
                    }
                    

                }
                else
                {
                    if (listek[x].worker_id == worker_id)
                    {
                        dt.Rows.Add(worker_name, worker_surname, api.getConstructionName(api.getAllConstructions(), listek[x].construction_id), listek[x].Timestamp_date, listek[x].Shift);


                        dataGridView1.DataSource = dt;
                    }
                    

                }
            }

            
        }

        private void Btn_export_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["List1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from gridview";
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            } 
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
        }
    }
}
