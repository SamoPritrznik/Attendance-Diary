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
    public partial class Admin_create_delete_update_worker : Form
    {
        string admin_id = "";

        API_Controller api = new API_Controller();
        
        public Admin_create_delete_update_worker(string _id)
        {
            InitializeComponent();
            admin_id = _id;
            Cmb_workers.Items.AddRange(api.WorkersToCmb(api.getAllWorkers()).ToArray());
        }

        public void Display()
        {
            Cmb_workers.Items.Clear();
            Cmb_workers.Items.AddRange(api.WorkersToCmb(api.getAllWorkers()).ToArray());
        }

        private void Btn_create_Click(object sender, EventArgs e)
        {
            string name = Txt_nam_create.Text;
            string surname = Txt_sur_create.Text;
            if(Txt_phone_create.Text.Length > 8 && Txt_phone_create.Text.Length < 13)
            {
                string phone = Txt_phone_create.Text;

                api.insertWorker(name, surname, phone);

                Display();
            }
            else
            {
                MessageBox.Show("Vnesi veljavno telefonsko številko");
            }
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_menu ad = new Admin_menu(admin_id);
            ad.Show();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            string[] words = Cmb_workers.SelectedItem.ToString().Split(' ');
            string worker_name = words[0];
            string worke_surname = words[1];

            string name = Txt_nam_edit.Text;
            string surname = Txt_sur_edit.Text;
            if (Txt_phone_edit.Text.Length > 8 && Txt_phone_edit.Text.Length < 13)
            {
                string phone = Txt_phone_edit.Text;

                api.updateWorker(name, surname, phone, worker_name, worke_surname, api.getAllWorkers());

                Display();
            }
            else
            {
                MessageBox.Show("Vnesi veljavno telefonsko številko");
            }
        }
    }
}
