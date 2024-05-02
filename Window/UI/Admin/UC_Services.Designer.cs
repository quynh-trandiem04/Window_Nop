namespace Window.UI.Admin
{
    partial class UC_Services
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_GiaTien = new System.Windows.Forms.Label();
            this.lbl_TenDV = new System.Windows.Forms.Label();
            this.lbl_MaDV = new System.Windows.Forms.Label();
            this.btn_Mua = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_AnhDichVu = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.lbl_GiaTien);
            this.panel1.Controls.Add(this.lbl_TenDV);
            this.panel1.Controls.Add(this.lbl_MaDV);
            this.panel1.Controls.Add(this.btn_Mua);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pic_AnhDichVu);
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 527);
            this.panel1.TabIndex = 1;
            // 
            // lbl_GiaTien
            // 
            this.lbl_GiaTien.AutoSize = true;
            this.lbl_GiaTien.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GiaTien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_GiaTien.Location = new System.Drawing.Point(135, 412);
            this.lbl_GiaTien.Name = "lbl_GiaTien";
            this.lbl_GiaTien.Size = new System.Drawing.Size(0, 21);
            this.lbl_GiaTien.TabIndex = 236;
            // 
            // lbl_TenDV
            // 
            this.lbl_TenDV.AutoSize = true;
            this.lbl_TenDV.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_TenDV.Location = new System.Drawing.Point(135, 363);
            this.lbl_TenDV.Name = "lbl_TenDV";
            this.lbl_TenDV.Size = new System.Drawing.Size(0, 21);
            this.lbl_TenDV.TabIndex = 235;
            // 
            // lbl_MaDV
            // 
            this.lbl_MaDV.AutoSize = true;
            this.lbl_MaDV.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaDV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_MaDV.Location = new System.Drawing.Point(135, 314);
            this.lbl_MaDV.Name = "lbl_MaDV";
            this.lbl_MaDV.Size = new System.Drawing.Size(0, 21);
            this.lbl_MaDV.TabIndex = 234;
            // 
            // btn_Mua
            // 
            this.btn_Mua.Location = new System.Drawing.Point(11, 463);
            this.btn_Mua.Name = "btn_Mua";
            this.btn_Mua.Size = new System.Drawing.Size(340, 45);
            this.btn_Mua.TabIndex = 233;
            this.btn_Mua.Text = "Buy";
            this.btn_Mua.UseVisualStyleBackColor = true;
            this.btn_Mua.Click += new System.EventHandler(this.btn_Mua_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(16, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 21);
            this.label7.TabIndex = 232;
            this.label7.Text = "Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(16, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 231;
            this.label5.Text = "Mã dịch vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 230;
            this.label1.Text = "Tên dịch vụ:";
            // 
            // pic_AnhDichVu
            // 
            this.pic_AnhDichVu.Location = new System.Drawing.Point(10, 14);
            this.pic_AnhDichVu.Name = "pic_AnhDichVu";
            this.pic_AnhDichVu.Size = new System.Drawing.Size(343, 271);
            this.pic_AnhDichVu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_AnhDichVu.TabIndex = 229;
            this.pic_AnhDichVu.TabStop = false;
            // 
            // UC_Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.panel1);
            this.Name = "UC_Services";
            this.Size = new System.Drawing.Size(390, 558);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_GiaTien;
        private System.Windows.Forms.Label lbl_TenDV;
        private System.Windows.Forms.Label lbl_MaDV;
        private System.Windows.Forms.Button btn_Mua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_AnhDichVu;
    }
}
