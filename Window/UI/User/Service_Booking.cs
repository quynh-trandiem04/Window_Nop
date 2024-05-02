﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Window.BL_Layer;

namespace Window.UI.User
{
    public partial class Service_Booking : Form
    {
        int MaDatPhong;
        public Service_Booking(int MaDatPhong)
        {
            this.MaDatPhong = MaDatPhong;
            InitializeComponent();
            Dichvu dichvu = new Dichvu();
            dichvu.DScacdichvu(flowLayoutPanel1, MaDatPhong);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
