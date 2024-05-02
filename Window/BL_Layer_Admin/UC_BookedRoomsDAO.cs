﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window.BL_Layer_Admin
{
    internal class UC_BookedRoomsDAO
    {
        QLKSCK_Entities db = new QLKSCK_Entities();
        public string layTenKhachHang(string a)
        {
            string b = "";
            var q = from k in db.KhachHangs where k.MaKH.ToString() == a select k;
            foreach (var k in q)
            {
                b = k.HoTen;
            }
            return b;
        }
        public string layMaNhanVien(string a)
        {
            string kq = "";
            var q = from k in db.NhanViens
                    join j in db.DangNhaps on k.TenDangNhap equals j.TenDangNhap
                    where a == k.TenDangNhap
                    select new
                    {
                        k,
                        j
                    };
            foreach (var item in q)
            {
                kq = item.k.MaNV;
            }
            return kq;
        }
        public void ThemHoaDon(HoaDon a)
        {
            db.HoaDons.Add(a);
            db.SaveChanges();
            MessageBox.Show("Đã trả phòng! Vui lòng vào mục thanh toán để tính tiền cho khách hàng có mã hóa đơn là: " + a.MaHoaDon);
        }
        public void Sua(string MaPhong, string MaDatPhong)
        {
            var p = from k in db.Phongs where k.MaPhong.ToString() == MaPhong select k;
            foreach (var j in p)
            {
                j.TinhTrang = "empty";
            }
            var q = from k in db.DatPhongs where k.MaDatPhong.ToString() == MaDatPhong select k;
            foreach (var j in q)
            {
                j.TinhTrang = "finish";
            }
            db.SaveChanges();
        }
    }
}
