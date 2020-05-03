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
            if(api.logInAdmin(obj, Txt_email.Text, Txt_password.Text))
            {
                this.Hide();
            }
        }
    }
}
