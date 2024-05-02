using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Window.UI.User;

namespace Window.BL_Layer
{
    internal class Tinhtien
    {
        QLKSCK_Entities db = new QLKSCK_Entities();
        public int tienphong(int maDatPhong)
        {
            var datPhong = db.DatPhongs.FirstOrDefault(dp => dp.MaDatPhong == maDatPhong);

            if (datPhong != null && datPhong.NgayDat != null && datPhong.NgayTra != null)
            {
                
                var phong = db.Phongs.FirstOrDefault(p => p.MaPhong == datPhong.MaPhong);

                if (phong != null && phong.LoaiPhong != null)
                {
                    var loaiPhong = db.LoaiPhongs.FirstOrDefault(lp => lp.MaLoaiPhong == phong.LoaiPhong);

                    if (loaiPhong != null && loaiPhong.Gia != null)
                    {
                        string d1 = datPhong.NgayTra.ToString();
                        string d2 = datPhong.NgayDat.ToString();
                        DateTime ngayTra = DateTime.Parse(d1);
                        DateTime ngayDat = DateTime.Parse(d2);
                        TimeSpan Time = ngayTra - ngayDat;
                        int diff = Time.Days;
                        if (diff >= 0)
                        {
                            int tienPhong = diff * loaiPhong.Gia.Value;
                            return tienPhong;
                        }
                    }
                }
            }
            return -1;
        }


        public int tiendichvu(string maDichVu, int soLuong)
        {
            int tongTienDichVu = 0;
            var dichVu = db.DichVus.FirstOrDefault(dv => dv.MaDV == maDichVu);

            if (dichVu != null)
            {
                tongTienDichVu = soLuong * Convert.ToInt32(dichVu.Gia);
            }
            return tongTienDichVu;
        }

        public int TienDichVu(int maDatPhong)
        {
            int tongTienDV = 0;
            var dichVu = db.TongDichVus.Where(dv => dv.MaDatPhong == maDatPhong).ToList();

            foreach (var dv in dichVu)
            {
                var maDichVu = db.DichVus.FirstOrDefault(p => p.MaDV == dv.MaDV);

                if (maDichVu != null && dv.SoLuong != null)
                {
                    tongTienDV += Convert.ToInt32(maDichVu.Gia) * dv.SoLuong ?? 0;
                }
            }
            return tongTienDV;
        }
    }
}
