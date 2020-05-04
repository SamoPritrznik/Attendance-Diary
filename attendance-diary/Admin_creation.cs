using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendance_diary
{
    public partial class Admin_creation : Form
    {
        string admin_id = "";
        API_Controller api = new API_Controller();
        public Admin_creation(string _id)
        {
            InitializeComponent();
            admin_id = _id;
            Cmb_admins.Items.AddRange(api.AdminsToCmb(api.getAllAdmins()).ToArray());
        }

        public async void display()
        {
            Cmb_admins.Items.Clear();
            Cmb_admins.Items.AddRange(api.AdminsToCmb(api.getAllAdmins()).ToArray());
        }

        private void Btn_create_Click(object sender, EventArgs e)
        {
            string name = Txt_nam_create.Text;
            string surname = Txt_sur_create.Text;
            string email = Txt_email_create.Text;
            string nonHashPassword = Txt_pass_create.Text;

            var data = Encoding.ASCII.GetBytes(nonHashPassword);

            var sha1 = new SHA1CryptoServiceProvider();
            var sha1data = sha1.ComputeHash(data);

            string hashedPassword = System.Text.Encoding.UTF8.GetString(sha1data);

            api.insertAdmin(name, surname, email, hashedPassword);
            

            display();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_menu ad = new Admin_menu(admin_id);
            ad.Show();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            string name = Txt_nam_edit.Text;
            string surname = Txt_sur_edit.Text;
            string email = Txt_email_edit.Text;
            string nonHashPassword = Txt_pass_edit.Text;

            var data = Encoding.ASCII.GetBytes(nonHashPassword);

            var sha1 = new SHA1CryptoServiceProvider();
            var sha1data = sha1.ComputeHash(data);


            string hashedPassword = System.Text.Encoding.UTF8.GetString(sha1data);

            string[] words = Cmb_admins.SelectedItem.ToString().Split(' ');
            string admin_name = words[0];
            string admin_surname = words[1];

            Console.WriteLine(admin_name + admin_surname);

            api.updateAdmin(name, surname, email, hashedPassword, admin_name, admin_surname, api.getAllAdmins());

            display();
        }
    }
}
