﻿using System;
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
    public partial class Admin_view_construction : Form
    {
        DataTable dt = new DataTable();

        API_Controller api = new API_Controller();

        public Admin_view_construction()
        {
            InitializeComponent();

            dataGridView1.DataSource = dt;

            Cmb_constructions.Items.AddRange(api.ConstructionsToCmb(api.getAllConstructions()).ToArray());
        }

        private void Cmb_constructions_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            dt.Columns.Clear();
            dt.Rows.Clear();
            DataRow dr = dt.NewRow();

            string words = Cmb_constructions.SelectedItem.ToString();

            string construction_id = api.getConstructionsId(api.getAllConstructions(), words);

            List<Time> listek = api.returnListTime(api.getAllTime(), construction_id);

            for (int x = 0; x < listek.Count; x++)
            {
                if (dt.Rows.Count <= 0)
                {
                    if (listek[x].construction_id == construction_id && Convert.ToDateTime(listek[x].Timestamp_date) >= Convert.ToDateTime(Date_begin_interval.Value) && Convert.ToDateTime(listek[x].Timestamp_date) <= Convert.ToDateTime(Date_end_interval.Value))
                    {
                        DataColumn dc1 = new DataColumn("Ime gradbišča", typeof(string));
                        DataColumn dc2 = new DataColumn("Ime delavca", typeof(string));
                        DataColumn dc3 = new DataColumn("Priimek delavca", typeof(string));
                        DataColumn dc4 = new DataColumn("Datum", typeof(string));
                        DataColumn dc5 = new DataColumn("Število opravljenih minut", typeof(string));

                        dt.Columns.Add(dc1);
                        dt.Columns.Add(dc2);
                        dt.Columns.Add(dc3);
                        dt.Columns.Add(dc4);
                        dt.Columns.Add(dc5);

                        dt.Rows.Add(words, api.getWorkerName(api.getAllWorkers(), listek[x].worker_id), api.getWorkerSurname(api.getAllWorkers(), listek[x].worker_id), listek[x].Timestamp_date, listek[x].Shift);

                        dataGridView1.DataSource = dt;
                    }


                }
                else
                {
                    if (listek[x].construction_id == construction_id && Convert.ToDateTime(listek[x].Timestamp_date) > Convert.ToDateTime(Date_begin_interval.Value) && Convert.ToDateTime(listek[x].Timestamp_date) < Convert.ToDateTime(Date_end_interval.Value))
                    {
                        dt.Rows.Add(words, api.getWorkerName(api.getAllWorkers(), listek[x].worker_id), api.getWorkerSurname(api.getAllWorkers(), listek[x].worker_id), listek[x].Timestamp_date, listek[x].Shift);

                        dataGridView1.DataSource = dt;
                    }


                }
            }


        }
    }
}
