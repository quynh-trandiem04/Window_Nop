using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Window.BL_Layer_Admin;

namespace Window.UI.Admin
{
    public partial class UC_Pay : UserControl
    {
        UC_PayDAO payDAO = new UC_PayDAO();
        public UC_Pay()
        {
            InitializeComponent();
            cb_TimKiem.DataSource = payDAO.loadMaHoaDon();
            cb_TimKiem.DisplayMember = "MaHoaDon";
            cb_TimKiem.ValueMember = "MaHoaDon";
            cb_TimKiem.SelectedIndex = -1;
        }

        private void btn_KiemTra_Click(object sender, EventArgs e)
        {
            if (cb_TimKiem.SelectedValue == null)
            {
                MessageBox.Show("Bạn chưa chọn mã thanh toán?", "Chú ý!");
            }
            else
            {
                payDAO.loadHoaDon(cb_TimKiem.SelectedValue.ToString(), this);
            }
        }
    }
}
