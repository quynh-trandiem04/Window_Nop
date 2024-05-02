﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Window.BL_Layer_Admin;

namespace Window.UI.Admin
{
    public partial class FixService : Form
    {
        FixServiceDAO servicedao = new FixServiceDAO();
        string anh;
        int flag;
        public FixService()
        {
            InitializeComponent();
            dg_DichVu.AutoGenerateColumns = false;
            LoadDataGridView();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            servicedao.SaveImage(pic_Anh, out anh);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            flag = 0;

            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;

            btn_Sua.Enabled = false;
            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
        }
        public void LoadDataGridView()
        {
            dg_DichVu.Columns.Clear();
            dg_DichVu.Columns.Add("MaDV", "Mã Dịch Vụ");
            dg_DichVu.Columns["MaDV"].DataPropertyName = "MaDV";

            dg_DichVu.Columns.Add("TenDV", "Tên Dịch Vụ");
            dg_DichVu.Columns["TenDV"].DataPropertyName = "TenDV";

            dg_DichVu.Columns.Add("Gia", "Giá");
            dg_DichVu.Columns["Gia"].DataPropertyName = "Gia";

            dg_DichVu.Columns.Add("Anh", "Ảnh");
            dg_DichVu.Columns["Anh"].DataPropertyName = "Anh";
            dg_DichVu.Columns["Anh"].Visible = false;

            dg_DichVu.DataSource = servicedao.LoadDV();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_MaDV.Text == "" || txt_TenDV.Text == "")
                MessageBox.Show("Bạn chưa chọn dữ liệu để xóa!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                servicedao.Xoa(txt_MaDV.Text);
                LoadDataGridView();
            }
            txt_MaDV.ResetText();
            txt_TenDV.ResetText();
            txt_GiaTien.ResetText();
            pic_Anh.Image = null;
            txt_MaDV.Focus();

            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;
            btn_Sua.Enabled = true;
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = true;
            LoadDataGridView();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            flag = 1;

            txt_MaDV.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;

            btn_Sua.Enabled = false;
            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (flag == 0) //Thêm
            {
                if (txt_MaDV.Text == "" || txt_TenDV.Text == "")
                    MessageBox.Show("Bạn chưa chọn dữ liệu để thêm!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (!servicedao.check(txt_MaDV.Text))
                {
                    MessageBox.Show("Dữ liệu đã tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DichVu a = new DichVu();
                    a.MaDV = txt_MaDV.Text;
                    a.TenDV = txt_TenDV.Text;
                    a.Gia = Convert.ToInt32(txt_GiaTien.Text);
                    a.Anh = anh;
                    servicedao.Them(a);
                    LoadDataGridView();
                }
                txt_MaDV.ResetText();
                txt_TenDV.ResetText();
                txt_GiaTien.ResetText();
                pic_Anh.Image = null;
                txt_MaDV.Focus();

                btn_Luu.Enabled = false;
                btn_Huy.Enabled = false;
                btn_Sua.Enabled = true;
                btn_Them.Enabled = true;
                btn_Xoa.Enabled = true;
                LoadDataGridView();
            }
            else if (flag == 1)  // Sửa dữ liệu
            {
                DichVu a = new DichVu();
                a.MaDV = txt_MaDV.Text;
                a.TenDV = txt_TenDV.Text;
                a.Gia = Convert.ToInt32(txt_GiaTien.Text);
                a.Anh = anh;
                servicedao.Sua(a);
                LoadDataGridView();

                txt_MaDV.ResetText();
                txt_TenDV.ResetText();
                txt_GiaTien.ResetText();
                pic_Anh.Image = null;
                txt_MaDV.Focus();

                btn_Luu.Enabled = false;
                btn_Huy.Enabled = false;
                btn_Sua.Enabled = true;
                btn_Them.Enabled = true;
                btn_Xoa.Enabled = true;

                txt_MaDV.Enabled = true;
                LoadDataGridView();
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_MaDV.ResetText();
            txt_TenDV.ResetText();
            txt_GiaTien.ResetText();
            pic_Anh.Image = null;
            txt_MaDV.Focus();

            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;

            btn_Sua.Enabled = true;
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = true;

            LoadDataGridView();
        }

        private void dg_DichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;

            int rowIndex = e.RowIndex;
            string s = dg_DichVu.Rows[rowIndex].Cells["Anh"].Value.ToString();
            string image1 = Path.Combine(appDirectory, s);
            txt_MaDV.Text = dg_DichVu.Rows[rowIndex].Cells["MaDV"].Value.ToString();
            txt_TenDV.Text = dg_DichVu.Rows[rowIndex].Cells["TenDV"].Value.ToString();
            txt_GiaTien.Text = dg_DichVu.Rows[rowIndex].Cells["Gia"].Value.ToString();
            pic_Anh.Image = Image.FromFile(image1);
            anh = s;
        }
    }
}
