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
    public partial class Meni : Form
    {
        public Meni()
        {
            InitializeComponent();
            
            
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_login ad = new Admin_login();
            ad.Show();
        }
    }
}
