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
    public partial class Admin_login : Form
    {
        public Admin_login()
        {
            InitializeComponent();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            API_Controller api = new API_Controller();
            string obj = api.getAllAdmins();

            string nonHashPassword = Txt_password.Text;

            var data = Encoding.ASCII.GetBytes(nonHashPassword);

            var sha1 = new SHA1CryptoServiceProvider();
            var sha1data = sha1.ComputeHash(data);

            string hashedPassword = System.Text.Encoding.UTF8.GetString(sha1data);

            if (api.logInAdmin(obj, Txt_email.Text, hashedPassword))
            {
                this.Close();
            }
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Meni me = new Meni();
            me.Close();
            this.Close();
        }
    }
}
