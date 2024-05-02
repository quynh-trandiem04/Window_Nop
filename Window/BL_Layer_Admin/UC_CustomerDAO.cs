using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window.BL_Layer_Admin
{
    internal class UC_CustomerDAO
    {
        QLKSCK_Entities db = new QLKSCK_Entities();
        public List<KhachHang> LoadKH()
        {
            var p = from k in db.KhachHangs select k;
            return p.ToList();
        }

        public List<KhachHang> LocKH(int a)
        {
            var p = from k in db.KhachHangs
                    where k.MaKH == a
                    select k;
            return p.ToList();
        }
    }
}
