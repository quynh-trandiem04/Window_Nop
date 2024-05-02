using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window.BL_Layer_Admin
{
    internal class UC_RoomsDAO
    {
        QLKSCK_Entities db = new QLKSCK_Entities();
        public void Sua(string MaPhong)
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
