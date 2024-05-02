using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Window.UI.User;

namespace Window.BL_Layer
{
    internal class Dichvu
    {
        QLKSCK_Entities db = new QLKSCK_Entities();
        public static class Dichvu_User
        {
            public static string dichvu { get; set; }
        }
        public string GetTenDichVuFromMaDV(string maDV)
        {
            using (var dbContext = new QLKSCK_Entities())
            {
                var dichVu = dbContext.DichVus.FirstOrDefault(dv => dv.MaDV == maDV);

                if (dichVu != null)
                {
                    return dichVu.TenDV;
                }
                else
                {
                    return "Không xác định";
                }
            }
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
        public void DScacdichvu(FlowLayoutPanel f, int MaDatPhong)
        {
            var services = db.DichVus.ToList(); 

            foreach (var service in services)
            {
                UC_Item_Service serviceItem = new UC_Item_Service(service, MaDatPhong);
                f.Controls.Add(serviceItem); 
            }
        }
        public bool Mua(int maDatPhong, string maDV, int soLuong)
        {
            try
            {
                using (var dbContext = new QLKSCK_Entities())
                {
                    var datPhong = dbContext.DatPhongs.SingleOrDefault(dp => dp.MaDatPhong == maDatPhong);
                    var dichVu = dbContext.DichVus.SingleOrDefault(dv => dv.MaDV == maDV);

                    if (datPhong == null || dichVu == null)
                    {
                        return false;
                    }
                    var chiTietMuaDichVu = dbContext.TongDichVus.SingleOrDefault(ct => ct.MaDatPhong == maDatPhong && ct.MaDV == maDV);

                    if (chiTietMuaDichVu != null)
                    {
                        chiTietMuaDichVu.SoLuong += soLuong;
                    }
                    else
                    {
                        chiTietMuaDichVu = new TongDichVu
                        {
                            MaDatPhong = maDatPhong,
                            MaDV = maDV,
                            SoLuong = soLuong
                        };
                        dbContext.TongDichVus.Add(chiTietMuaDichVu);
                    }

                    dbContext.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }

    }
}
