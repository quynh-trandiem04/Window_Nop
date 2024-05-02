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
using Window.UI_Giaodien;

namespace Window.UI.Admin
{
    public partial class UC_Customer : UserControl
    {
        UC_CustomerDAO uccustomerdao = new UC_CustomerDAO();
        public UC_Customer()
        {
            InitializeComponent();
            dg_KhachHang.AutoGenerateColumns = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {

            dg_KhachHang.DataSource = uccustomerdao.LoadKH();
        }
        private void btn_KiemTra_Click(object sender, EventArgs e)
        {
            if (txt_MaKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng!", "Chú ý");
            }
            else
            {
                uccustomerdao = new UC_CustomerDAO();
                dg_KhachHang.DataSource = uccustomerdao.LocKH(Convert.ToInt32(txt_MaKH.Text));
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string s = dg_KhachHang.Rows[rowIndex].Cells["MaKH"].Value.ToString();

            CustomerDetail a = new CustomerDetail(s);
            a.ShowDialog();
        }

        private void txt_MaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Registeraccount f = new Registeraccount();
            f.ShowDialog();
        }
    }
}
