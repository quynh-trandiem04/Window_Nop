using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window.BL_Layer_Admin
{
    internal class UC_HistoryDAO
    {
        QLKSCK_Entities db = new QLKSCK_Entities();
        public string layTenKH(int a)
        {
            string b = "";
            var q = from k in db.KhachHangs
                    where k.MaKH == a
                    select k;
            foreach (var k in q)
            {
                b = k.HoTen;
            }
            return b;
        }

        public List<DatPhong> loadLichSu(int a)
        {
            var p = from k in db.DatPhongs
                    where k.MaKH == a
                    select k;
            return p.ToList();
        }
    }
}
