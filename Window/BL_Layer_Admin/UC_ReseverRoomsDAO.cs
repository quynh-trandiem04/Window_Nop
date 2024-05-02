using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window.BL_Layer_Admin
{
    internal class UC_ReseverRoomsDAO
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
        public void sua(string MaPhong)
        {
            var p = from k in db.Phongs where k.MaPhong.ToString() == MaPhong select k;
            foreach (var j in p)
            {
                j.TinhTrang = "full";
            }
            db.SaveChanges();
        }
    }
}
