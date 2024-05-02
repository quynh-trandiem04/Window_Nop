using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Window.BL_Layer;

namespace Window.UI.User
{
    public partial class Information_Current_Room_Booked : Form
    {
        private UC_Item_Current_Room ucItemCurrentRoom;
        string loggedInUsername = Giaodien.TenDangNhap_User.LoggedInUsername;
        Phongdangdat phongdangdat = new Phongdangdat();
        Datphong datphong = new Datphong();
        Tinhtien tinhtien = new Tinhtien();
        int madatPhong;
        public Information_Current_Room_Booked(int MaDatPhong, UC_Item_Current_Room uC_Item_Current_Room)
        {
            InitializeComponent();
            this.madatPhong = MaDatPhong;
            this.ucItemCurrentRoom = uC_Item_Current_Room;
            string hoTen = datphong.HoTen(loggedInUsername);
            lb_tenkh.Text = hoTen;
            var chiTietDatPhong = phongdangdat.Chitietdatphong(madatPhong);

            if (chiTietDatPhong != null)
            {
                lb_maphong.Text = chiTietDatPhong.MaPhong.ToString();
                lb_maloaiphong.Text = chiTietDatPhong.LoaiPhong;
                lb_thoigiandat.Text = chiTietDatPhong.ThoiGianDat.ToString();
                lb_ngaydat.Text = chiTietDatPhong.NgayDat.ToString();
                lb_ngaytra.Text = chiTietDatPhong.NgayTra.ToString();
                lb_songuoi.Text = chiTietDatPhong.SoNguoi.ToString();
                lb_gia.Text = tinhtien.tienphong(madatPhong).ToString();
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_themdichvu_Click(object sender, EventArgs e)
        {
            Service_Booking booking = new Service_Booking(madatPhong);
            booking.Show();
        }

        private void btn_huydat_Click(object sender, EventArgs e)
        {
            if (phongdangdat.Huydat(madatPhong))
            {
                MessageBox.Show("Hủy đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucItemCurrentRoom.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Không thể hủy đặt phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Load_Form_Click(object sender, EventArgs e)
        {
            lb_gia.Text = (tinhtien.TienDichVu(madatPhong) + tinhtien.tienphong(madatPhong)).ToString();
        }
    }
}
