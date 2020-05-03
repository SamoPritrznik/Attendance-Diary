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
    public partial class Admin_note_shift : Form
    {
        public string admin_id;
        API_Controller api = new API_Controller();
        public Admin_note_shift(string _id)
        {
            InitializeComponent();
            admin_id = _id;
            CmbBx_worker.Items.AddRange(api.WorkersToCmb(api.getAllWorkers()).ToArray());
            CmbBx_construction.Items.AddRange(api.ConstructionsToCmb(api.getAllConstructions()).ToArray());
        }

        private void Btn_addTime_Click(object sender, EventArgs e)
        {
            string iDate = DateTimePickerShift.Value.ToString("yyyy-MM-dd");
            int Shift = Convert.ToInt32(Txt_minutes.Text);

            string[] words = CmbBx_worker.SelectedItem.ToString().Split(' ');
            string worker_name = words[0];
            string worke_surname = words[1];
            string worker_id = api.getWorkerId(api.getAllWorkers(), worker_name, worke_surname);

            string construction_site_name = CmbBx_construction.SelectedItem.ToString();
            string construction_id = api.getConstructionsId(api.getAllConstructions(), construction_site_name);

            api.addTime(admin_id, worker_id, construction_id, Shift, iDate);
        }

        private void DateTimePickerShift_ValueChanged(object sender, EventArgs e)
        {
            DateTimePickerShift.MinDate = new DateTime(1985, 6, 20);
            DateTimePickerShift.MaxDate = DateTime.Today;

            DateTimePickerShift.Format = DateTimePickerFormat.Custom;
            DateTimePickerShift.CustomFormat = "yyyy-MM-dd";
        }
    }
}
