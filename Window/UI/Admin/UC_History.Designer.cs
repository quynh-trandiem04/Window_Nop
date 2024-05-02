namespace Window.UI.Admin
{
    partial class UC_History
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg_LichSu = new System.Windows.Forms.DataGridView();
            this.MaDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_KiemTra = new System.Windows.Forms.Button();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.kh = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_TenKH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_LichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_LichSu
            // 
            this.dg_LichSu.BackgroundColor = System.Drawing.Color.White;
            this.dg_LichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_LichSu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDP,
            this.MaKH,
            this.MaPhong,
            this.NgayDat,
            this.NgayTra,
            this.ThoiGianDat,
            this.TinhTrang});
            this.dg_LichSu.Location = new System.Drawing.Point(29, 161);
            this.dg_LichSu.Name = "dg_LichSu";
            this.dg_LichSu.RowHeadersWidth = 51;
            this.dg_LichSu.RowTemplate.Height = 24;
            this.dg_LichSu.Size = new System.Drawing.Size(988, 402);
            this.dg_LichSu.TabIndex = 265;
            // 
            // MaDP
            // 
            this.MaDP.DataPropertyName = "MaDatPhong";
            this.MaDP.HeaderText = "Mã đặt phòng";
            this.MaDP.MinimumWidth = 6;
            this.MaDP.Name = "MaDP";
            this.MaDP.Width = 125;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 125;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Width = 125;
            // 
            // NgayDat
            // 
            this.NgayDat.DataPropertyName = "NgayDat";
            this.NgayDat.HeaderText = "Ngày đặt";
            this.NgayDat.MinimumWidth = 6;
            this.NgayDat.Name = "NgayDat";
            this.NgayDat.Width = 125;
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày trả";
            this.NgayTra.MinimumWidth = 6;
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.Width = 125;
            // 
            // ThoiGianDat
            // 
            this.ThoiGianDat.DataPropertyName = "ThoiGianDat";
            this.ThoiGianDat.HeaderText = "Thời gian đặt";
            this.ThoiGianDat.MinimumWidth = 6;
            this.ThoiGianDat.Name = "ThoiGianDat";
            this.ThoiGianDat.Width = 125;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 125;
            // 
            // btn_KiemTra
            // 
            this.btn_KiemTra.Location = new System.Drawing.Point(726, 67);
            this.btn_KiemTra.Name = "btn_KiemTra";
            this.btn_KiemTra.Size = new System.Drawing.Size(113, 30);
            this.btn_KiemTra.TabIndex = 264;
            this.btn_KiemTra.Text = "Search";
            this.btn_KiemTra.UseVisualStyleBackColor = true;
            this.btn_KiemTra.Click += new System.EventHandler(this.btn_KiemTra_Click);
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(410, 71);
            this.txt_MaKH.Multiline = true;
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(282, 25);
            this.txt_MaKH.TabIndex = 263;
            this.txt_MaKH.TextChanged += new System.EventHandler(this.txt_MaKH_TextChanged);
            this.txt_MaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaKH_KeyPress);
            // 
            // kh
            // 
            this.kh.AutoSize = true;
            this.kh.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kh.Location = new System.Drawing.Point(265, 72);
            this.kh.Name = "kh";
            this.kh.Size = new System.Drawing.Size(123, 21);
            this.kh.TabIndex = 262;
            this.kh.Text = "Mã khách hàng:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(21, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 45);
            this.label12.TabIndex = 261;
            this.label12.Text = "HISTORY";
            // 
            // lbl_TenKH
            // 
            this.lbl_TenKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(38)))));
            this.lbl_TenKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_TenKH.ForeColor = System.Drawing.Color.White;
            this.lbl_TenKH.Location = new System.Drawing.Point(410, 113);
            this.lbl_TenKH.Multiline = true;
            this.lbl_TenKH.Name = "lbl_TenKH";
            this.lbl_TenKH.Size = new System.Drawing.Size(282, 27);
            this.lbl_TenKH.TabIndex = 266;
            // 
            // UC_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.lbl_TenKH);
            this.Controls.Add(this.dg_LichSu);
            this.Controls.Add(this.btn_KiemTra);
            this.Controls.Add(this.txt_MaKH);
            this.Controls.Add(this.kh);
            this.Controls.Add(this.label12);
            this.Name = "UC_History";
            this.Size = new System.Drawing.Size(1039, 586);
            ((System.ComponentModel.ISupportInitialize)(this.dg_LichSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_LichSu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.Button btn_KiemTra;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Label kh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox lbl_TenKH;
    }
}
