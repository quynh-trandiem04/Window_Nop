using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window.BL_Layer_Admin
{
    internal class CustomerDetailDAO
    {
        QLKSCK_Entities db = new QLKSCK_Entities();

        public KhachHang LoadData(string s)
        {
            KhachHang khachhang = db.KhachHangs.FirstOrDefault(kh => kh.MaKH.ToString() == s);
            return khachhang;
        }

        public void Luu(KhachHang a)
        {
            var p = db.KhachHangs.FirstOrDefault(k => k.MaKH == a.MaKH);
            if (p != null)
            {
                p.HoTen = a.HoTen;
                p.DiaChi = a.DiaChi;
                p.SDT = a.SDT;
                p.TenDangNhap = a.TenDangNhap;
                p.CCCD = a.CCCD;
                p.NgaySinh = a.NgaySinh;
                p.GioiTinh = a.GioiTinh;
                p.Anh = a.Anh;

                db.SaveChanges();
            }
            db.SaveChanges();
            MessageBox.Show("Sửa thông tin khách hàng thành công!");
        }
        public void SaveImage(PictureBox image, out string filename)
        {
            filename = string.Empty;
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                image.Image = Image.FromFile(opf.FileName);
                filename = Path.GetFileName(opf.FileName);
                string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                string dest = Path.Combine(appDirectory, filename);
                File.Copy(opf.FileName, dest, true);
            }
        }
    }
}
