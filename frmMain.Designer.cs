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
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dantoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemhethong = new System.Windows.Forms.ToolStripMenuItem();
            this.itemdangnhap = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dgvNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.hoten,
            this.ngaysinh,
            this.gioitinh,
            this.quequan,
            this.dantoc,
            this.sodienthoai,
            this.taikhoan,
            this.chucvu,
            this.luong,
            this.phongban,
            this.hocvan});
            this.dgvNV.Location = new System.Drawing.Point(0, 44);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.ReadOnly = true;
            this.dgvNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNV.Size = new System.Drawing.Size(1161, 478);
            this.dgvNV.TabIndex = 1;
            // 
            // ma
            // 
            this.ma.DataPropertyName = "ma";
            this.ma.FillWeight = 30F;
            this.ma.HeaderText = "Mã";
            this.ma.Name = "ma";
            this.ma.ReadOnly = true;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.FillWeight = 54.63992F;
            this.hoten.HeaderText = "Họ tên";
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.FillWeight = 54.63992F;
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.FillWeight = 54.63992F;
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            // 
            // quequan
            // 
            this.quequan.DataPropertyName = "quequan";
            this.quequan.FillWeight = 54.63992F;
            this.quequan.HeaderText = "Quê quán";
            this.quequan.Name = "quequan";
            this.quequan.ReadOnly = true;
            // 
            // dantoc
            // 
            this.dantoc.DataPropertyName = "dantoc";
            this.dantoc.FillWeight = 54.63992F;
            this.dantoc.HeaderText = "Dân tộc";
            this.dantoc.Name = "dantoc";
            this.dantoc.ReadOnly = true;
            // 
            // sodienthoai
            // 
            this.sodienthoai.DataPropertyName = "sodienthoai";
            this.sodienthoai.FillWeight = 54.63992F;
            this.sodienthoai.HeaderText = "Số điện thoại";
            this.sodienthoai.Name = "sodienthoai";
            this.sodienthoai.ReadOnly = true;
            // 
            // taikhoan
            // 
            this.taikhoan.DataPropertyName = "taikhoan";
            this.taikhoan.FillWeight = 54.63992F;
            this.taikhoan.HeaderText = "Tài khoản";
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.ReadOnly = true;
            // 
            // chucvu
            // 
            this.chucvu.DataPropertyName = "chucvu";
            this.chucvu.FillWeight = 54.63992F;
            this.chucvu.HeaderText = "Chức vụ";
            this.chucvu.Name = "chucvu";
            this.chucvu.ReadOnly = true;
            // 
            // luong
            // 
            this.luong.DataPropertyName = "luong";
            this.luong.FillWeight = 54.63992F;
            this.luong.HeaderText = "Lương";
            this.luong.Name = "luong";
            this.luong.ReadOnly = true;
            // 
            // phongban
            // 
            this.phongban.DataPropertyName = "phongban";
            this.phongban.FillWeight = 54.63992F;
            this.phongban.HeaderText = "Phòng ban";
            this.phongban.Name = "phongban";
            this.phongban.ReadOnly = true;
            // 
            // hocvan
            // 
            this.hocvan.DataPropertyName = "hocvan";
            this.hocvan.FillWeight = 54.63992F;
            this.hocvan.HeaderText = "Học vấn";
            this.hocvan.Name = "hocvan";
            this.hocvan.ReadOnly = true;
            // 
            // itemhethong
            // 
            this.itemhethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemdangnhap,
            this.itemDangXuat});
            this.itemhethong.Name = "itemhethong";
            this.itemhethong.Size = new System.Drawing.Size(76, 23);
            this.itemhethong.Text = "Hệ thống";
            // 
            // itemdangnhap
            // 
            this.itemdangnhap.Name = "itemdangnhap";
            this.itemdangnhap.Size = new System.Drawing.Size(143, 24);
            this.itemdangnhap.Text = "Đăng nhập";
            this.itemdangnhap.Click += new System.EventHandler(this.itemdangnhap_Click);
            // 
            // itemDangXuat
            // 
            this.itemDangXuat.Name = "itemDangXuat";
            this.itemDangXuat.Size = new System.Drawing.Size(143, 24);
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
            this.itemquanlynguoidung.Size = new System.Drawing.Size(139, 23);
            this.itemquanlynguoidung.Text = "Quản lý người dùng";
            // 
            // itemtimkiem
            // 
            this.itemtimkiem.Name = "itemtimkiem";
            this.itemtimkiem.Size = new System.Drawing.Size(189, 24);
            this.itemtimkiem.Text = "Tìm kiếm";
            this.itemtimkiem.Click += new System.EventHandler(this.itemtimkiem_Click);
            // 
            // itemthemnhansumoi
            // 
            this.itemthemnhansumoi.Name = "itemthemnhansumoi";
            this.itemthemnhansumoi.Size = new System.Drawing.Size(189, 24);
            this.itemthemnhansumoi.Text = "Thêm nhân sự mới";
            this.itemthemnhansumoi.Click += new System.EventHandler(this.itemthemnhansumoi_Click);
            // 
            // itemsuanhansu
            // 
            this.itemsuanhansu.Name = "itemsuanhansu";
            this.itemsuanhansu.Size = new System.Drawing.Size(189, 24);
            this.itemsuanhansu.Text = "Sửa nhân sự";
            this.itemsuanhansu.Click += new System.EventHandler(this.itemsuanhansu_Click);
            // 
            // itemxoanhansu
            // 
            this.itemxoanhansu.Name = "itemxoanhansu";
            this.itemxoanhansu.Size = new System.Drawing.Size(189, 24);
            this.itemxoanhansu.Text = "Xóa nhân sự";
            this.itemxoanhansu.Click += new System.EventHandler(this.itemxoanhansu_Click);
            // 
            // itemhuongdansudung
            // 
            this.itemhuongdansudung.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.itemhuongdansudung.Name = "itemhuongdansudung";
            this.itemhuongdansudung.Size = new System.Drawing.Size(141, 23);
            this.itemhuongdansudung.Text = "Hướng dẫn sử dụng";
            this.itemhuongdansudung.Click += new System.EventHandler(this.itemhuongdansudung_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemhethong,
            this.itemquanlynguoidung,
            this.itemhuongdansudung});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1161, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
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
        private System.Windows.Forms.ToolStripMenuItem itemdangnhap;
        private System.Windows.Forms.ToolStripMenuItem itemquanlynguoidung;
        private System.Windows.Forms.ToolStripMenuItem itemtimkiem;
        private System.Windows.Forms.ToolStripMenuItem itemthemnhansumoi;
        private System.Windows.Forms.ToolStripMenuItem itemsuanhansu;
        private System.Windows.Forms.ToolStripMenuItem itemxoanhansu;
        private System.Windows.Forms.ToolStripMenuItem itemhuongdansudung;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dantoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn taikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn phongban;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocvan;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.ToolStripMenuItem itemDangXuat;
    }
}