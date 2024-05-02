using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Window.UI.Admin
{
    public partial class UC_Services : UserControl
    {
        string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        public UC_Services(DichVu f)
        {
            InitializeComponent();
            lbl_MaDV.Text = f.MaDV;
            lbl_TenDV.Text = f.TenDV;
            lbl_GiaTien.Text = f.Gia.ToString();
            string image1 = Path.Combine(appDirectory, f.Anh);
            pic_AnhDichVu.Image = Image.FromFile(image1);
        }

        private void btn_Mua_Click(object sender, EventArgs e)
        {
            BuyService a = new BuyService(lbl_MaDV.Text, lbl_TenDV.Text);
            a.ShowDialog();
        }
    }
}
