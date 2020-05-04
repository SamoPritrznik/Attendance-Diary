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
    public partial class Admin_create_delete_update_construction : Form
    {
        public string admin_id = "";

        API_Controller api = new API_Controller();

        public Admin_create_delete_update_construction(string _id)
        {
            InitializeComponent();
            admin_id = _id;
            Display();
        }

        public void Display()
        {
            Cmb_constructions.Items.Clear();
            Cmb_constructions.Items.AddRange(api.ConstructionsToCmb(api.getAllConstructions()).ToArray());
        }

        private void Btn_create_Click(object sender, EventArgs e)
        {
            string location = Txt_location_create.Text;
            string site_name = Txt_site_name_create.Text;

            if (Btn_bool_used_create.Checked == true)
            {
                Boolean used = true;
                api.insertConstruction(location, site_name, used);
            }
            else
            {
                Boolean used = false;
                api.insertConstruction(location, site_name, used);
            }

            Display();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_menu ad = new Admin_menu(admin_id);
            ad.Show();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            string location = Txt_location_edit.Text;
            string site_name = Txt_site_name_edit.Text;

            string construction_site_name = Cmb_constructions.SelectedItem.ToString();

            if (Btn_boolean_used_edit.Checked == true)
            {
                Boolean used = true;
                api.updateConstruction(location, site_name, used, construction_site_name, api.getAllConstructions());
            }
            else
            {
                Boolean used = false;
                api.updateConstruction(location, site_name, used, construction_site_name, api.getAllConstructions());
            }

            Display();
        }
    }
}
