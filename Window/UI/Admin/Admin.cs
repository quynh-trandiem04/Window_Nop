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
    public partial class Admin : Form
    {
        UI_Giaodien.UC_Home home = new UI_Giaodien.UC_Home();
        AdminDAO admin = new AdminDAO();
        string tendnNV;
        int panelWidth;
        bool Hidden;
        public Admin(string s)
        {
            InitializeComponent();
            panelWidth = PanelSlide.Width;
            Hidden = false;
            SidePanel.Height = btn_XemPhong.Height;
            SidePanel.Top = btn_XemPhong.Top;
            home = new UI_Giaodien.UC_Home();
            pn_HienThi.Controls.Add(home);
            tendnNV = s;
            btn_DieuChinhDV.Visible = false;
            btn_DieuChinhDV.Enabled = false;
        }
        
        private void btn_XemPhong_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_XemPhong.Height;
            SidePanel.Top = btn_XemPhong.Top;
            admin = new AdminDAO();
            admin.loadAllUCRooms(this);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = (MessageBox.Show("Bạn có muốn thoát không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (traloi == DialogResult.Yes) Application.Exit();
        }
        public void Refresh()
        {
            pn_HienThi.Controls.Clear();
            btn_DieuChinhDV.Enabled = false;
            btn_DieuChinhDV.Visible = false;
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btn_XemPhongDat_Click(object sender, EventArgs e)
        {
            admin = new AdminDAO();
            admin.loadAllUCBookedRooms(this, tendnNV);
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            Refresh();
            admin = new AdminDAO();
            admin.loadThanhToan(pn_HienThi);
        }

        private void btn_CheckIn_Click(object sender, EventArgs e)
        {
            admin = new AdminDAO();
            admin.loadAllUCReserveRooms(this, tendnNV);
        }

        private void btn_DichVu_Click(object sender, EventArgs e)
        {
            Refresh();
            admin = new AdminDAO();
            admin.loadAllUCServices(pn_HienThi);
            btn_DieuChinhDV.Enabled = true;
            btn_DieuChinhDV.Visible = true;
        }

        private void btn_DieuChinhDV_Click(object sender, EventArgs e)
        {
            FixService a = new FixService();
            a.ShowDialog();
        }

        private void btn_LichSuGiaoDich_Click(object sender, EventArgs e)
        {
            Refresh();
            admin = new AdminDAO();
            admin.loadLichSu(pn_HienThi);
        }

        private void btn_ThongTinKhachHang_Click(object sender, EventArgs e)
        {
            Refresh();
            admin = new AdminDAO();
            admin.loadKhachHang(pn_HienThi);
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = (MessageBox.Show("Bạn có muốn đăng xuất không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (traloi == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
