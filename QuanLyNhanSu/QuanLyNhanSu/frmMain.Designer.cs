namespace QuanLyNhanSu
{
    partial class frmmain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.itemhethong = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.itemquanlynguoidung = new System.Windows.Forms.ToolStripMenuItem();
            this.itemtimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemthemnhansumoi = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsuanhansu = new System.Windows.Forms.ToolStripMenuItem();
            this.itemxoanhansu = new System.Windows.Forms.ToolStripMenuItem();
            this.itemhuongdansudung = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.clMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDanToc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChuVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHocVan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNV
            // 
            this.dgvNV.AllowUserToAddRows = false;
            this.dgvNV.AllowUserToDeleteRows = false;
            this.dgvNV.AllowUserToResizeColumns = false;
            this.dgvNV.AllowUserToResizeRows = false;
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMa,
            this.clHoTen,
            this.clNgaySinh,
            this.clQueQuan,
            this.clGioiTinh,
            this.clDanToc,
            this.clSDT,
            this.clTaiKhoan,
            this.clLuong,
            this.clChuVu,
            this.clPhongBan,
            this.clHocVan});
            this.dgvNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvNV.Location = new System.Drawing.Point(0, 25);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.ReadOnly = true;
            this.dgvNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNV.Size = new System.Drawing.Size(1161, 497);
            this.dgvNV.TabIndex = 1;
            this.dgvNV.Visible = false;
            // 
            // itemhethong
            // 
            this.itemhethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDangXuat});
            this.itemhethong.Name = "itemhethong";
            this.itemhethong.Size = new System.Drawing.Size(74, 21);
            this.itemhethong.Text = "Hệ thống";
            // 
            // itemDangXuat
            // 
            this.itemDangXuat.Name = "itemDangXuat";
            this.itemDangXuat.Size = new System.Drawing.Size(152, 22);
            this.itemDangXuat.Text = "Đăng xuất";
            this.itemDangXuat.Click += new System.EventHandler(this.itemDangXuat_Click);
            // 
            // itemquanlynguoidung
            // 
            this.itemquanlynguoidung.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemtimkiem,
            this.itemthemnhansumoi,
            this.itemsuanhansu,
            this.itemxoanhansu});
            this.itemquanlynguoidung.Name = "itemquanlynguoidung";
            this.itemquanlynguoidung.Size = new System.Drawing.Size(135, 21);
            this.itemquanlynguoidung.Text = "Quản lý người dùng";
            // 
            // itemtimkiem
            // 
            this.itemtimkiem.Name = "itemtimkiem";
            this.itemtimkiem.Size = new System.Drawing.Size(186, 22);
            this.itemtimkiem.Text = "Tìm kiếm";
            this.itemtimkiem.Click += new System.EventHandler(this.itemtimkiem_Click);
            // 
            // itemthemnhansumoi
            // 
            this.itemthemnhansumoi.Name = "itemthemnhansumoi";
            this.itemthemnhansumoi.Size = new System.Drawing.Size(186, 22);
            this.itemthemnhansumoi.Text = "Thêm nhân sự mới";
            this.itemthemnhansumoi.Click += new System.EventHandler(this.itemthemnhansumoi_Click);
            // 
            // itemsuanhansu
            // 
            this.itemsuanhansu.Name = "itemsuanhansu";
            this.itemsuanhansu.Size = new System.Drawing.Size(186, 22);
            this.itemsuanhansu.Text = "Sửa nhân sự";
            this.itemsuanhansu.Click += new System.EventHandler(this.itemsuanhansu_Click);
            // 
            // itemxoanhansu
            // 
            this.itemxoanhansu.Name = "itemxoanhansu";
            this.itemxoanhansu.Size = new System.Drawing.Size(186, 22);
            this.itemxoanhansu.Text = "Xóa nhân sự";
            this.itemxoanhansu.Click += new System.EventHandler(this.itemxoanhansu_Click);
            // 
            // itemhuongdansudung
            // 
            this.itemhuongdansudung.Name = "itemhuongdansudung";
            this.itemhuongdansudung.Size = new System.Drawing.Size(136, 21);
            this.itemhuongdansudung.Text = "Hướng dẫn sử dụng";
            this.itemhuongdansudung.Click += new System.EventHandler(this.itemhuongdansudung_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemhethong,
            this.itemquanlynguoidung,
            this.itemhuongdansudung});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1161, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 522);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1161, 0);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(1034, 460);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(96, 34);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Visible = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(1034, 460);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(96, 34);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Visible = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // clMa
            // 
            this.clMa.DataPropertyName = "Ma";
            this.clMa.HeaderText = "Mã";
            this.clMa.Name = "clMa";
            this.clMa.ReadOnly = true;
            // 
            // clHoTen
            // 
            this.clHoTen.DataPropertyName = "HoTen";
            this.clHoTen.HeaderText = "Họ tên";
            this.clHoTen.Name = "clHoTen";
            this.clHoTen.ReadOnly = true;
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.DataPropertyName = "NgaySinh";
            this.clNgaySinh.HeaderText = "Ngày sinh";
            this.clNgaySinh.Name = "clNgaySinh";
            this.clNgaySinh.ReadOnly = true;
            // 
            // clQueQuan
            // 
            this.clQueQuan.DataPropertyName = "QueQuan";
            this.clQueQuan.HeaderText = "Quê quán";
            this.clQueQuan.Name = "clQueQuan";
            this.clQueQuan.ReadOnly = true;
            // 
            // clGioiTinh
            // 
            this.clGioiTinh.DataPropertyName = "GioiTinh";
            this.clGioiTinh.HeaderText = "Giới tính";
            this.clGioiTinh.Name = "clGioiTinh";
            this.clGioiTinh.ReadOnly = true;
            // 
            // clDanToc
            // 
            this.clDanToc.DataPropertyName = "DanToc";
            this.clDanToc.HeaderText = "Dân tộc";
            this.clDanToc.Name = "clDanToc";
            this.clDanToc.ReadOnly = true;
            // 
            // clSDT
            // 
            this.clSDT.DataPropertyName = "SoDienThoai";
            this.clSDT.HeaderText = "SDT";
            this.clSDT.Name = "clSDT";
            this.clSDT.ReadOnly = true;
            // 
            // clTaiKhoan
            // 
            this.clTaiKhoan.DataPropertyName = "TaiKhoan";
            this.clTaiKhoan.HeaderText = "Tài khoản";
            this.clTaiKhoan.Name = "clTaiKhoan";
            this.clTaiKhoan.ReadOnly = true;
            // 
            // clLuong
            // 
            this.clLuong.DataPropertyName = "LuongConBan";
            this.clLuong.HeaderText = "Lương";
            this.clLuong.Name = "clLuong";
            this.clLuong.ReadOnly = true;
            // 
            // clChuVu
            // 
            this.clChuVu.DataPropertyName = "ChuVuMa";
            this.clChuVu.HeaderText = "Mã CV";
            this.clChuVu.Name = "clChuVu";
            this.clChuVu.ReadOnly = true;
            // 
            // clPhongBan
            // 
            this.clPhongBan.DataPropertyName = "PhongBanMa";
            this.clPhongBan.HeaderText = "Mã PB";
            this.clPhongBan.Name = "clPhongBan";
            this.clPhongBan.ReadOnly = true;
            // 
            // clHocVan
            // 
            this.clHocVan.DataPropertyName = "HocVanMa";
            this.clHocVan.HeaderText = "Mã HV";
            this.clHocVan.Name = "clHocVan";
            this.clHocVan.ReadOnly = true;
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 522);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNV);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Sự";
            this.Activated += new System.EventHandler(this.frmmain_Activated);
            this.Load += new System.EventHandler(this.frmmain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.ToolStripMenuItem itemhethong;
        private System.Windows.Forms.ToolStripMenuItem itemquanlynguoidung;
        private System.Windows.Forms.ToolStripMenuItem itemtimkiem;
        private System.Windows.Forms.ToolStripMenuItem itemthemnhansumoi;
        private System.Windows.Forms.ToolStripMenuItem itemsuanhansu;
        private System.Windows.Forms.ToolStripMenuItem itemxoanhansu;
        private System.Windows.Forms.ToolStripMenuItem itemhuongdansudung;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.ToolStripMenuItem itemDangXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDanToc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChuVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHocVan;
    }
}