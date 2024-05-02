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
    public partial class BuyService : Form
    {
        BuyServiceDAO buy = new BuyServiceDAO();
        string madv;
        public BuyService(string a, string b)
        {
            InitializeComponent();
            madv = a;
            lbl_TenDV.Text = b;
            cbb_MaDatPhong.DataSource = buy.loadMaDatPhong();
            cbb_MaDatPhong.DisplayMember = "MaPhong";
            cbb_MaDatPhong.ValueMember = "MaDatPhong";
            cbb_MaDatPhong.SelectedIndex = -1;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Mua_Click(object sender, EventArgs e)
        {
            if (cbb_MaDatPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn phòng!", "Chú ý");
            }
            else if (txt_SoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng!", "Chú ý");
            }
            else
            {
                TongDichVu a = new TongDichVu();
                a.MaDV = madv;
                string madatphong = cbb_MaDatPhong.SelectedValue.ToString();
                a.MaDatPhong = Convert.ToInt32(madatphong);
                a.SoLuong = Convert.ToInt32(txt_SoLuong.Text);
                buy.themDichVu(a);
                MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo");
                this.Close();
            }
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbb_MaDatPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_MaDatPhong.SelectedValue != null)
            {
                string madatphong = cbb_MaDatPhong.SelectedValue.ToString();
                lbl_TenKH.Text = buy.layTenKH(madatphong);
            }
        }
    }
}
