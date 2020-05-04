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
    public partial class Admin_menu : Form
    {
        string admin_id;

        public Admin_menu(string _id)
        {
            InitializeComponent();
            admin_id = _id;
        }

        private void Btn_shift_Click(object sender, EventArgs e)
        {
            Admin_note_shift ad = new Admin_note_shift(admin_id);
            ad.Show();
        }

        private void Btn_admin_creation_Click(object sender, EventArgs e)
        {
            Admin_creation ad = new Admin_creation(admin_id);
            ad.Show();
            this.Hide();
        }
    }
}
