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
            this.dgbNS = new System.Windows.Forms.DataGridView();
            this.itemhethong = new System.Windows.Forms.ToolStripMenuItem();
            this.itemdangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.itemquanlynguoidung = new System.Windows.Forms.ToolStripMenuItem();
            this.itemtimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemthemnhansumoi = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsuanhansu = new System.Windows.Forms.ToolStripMenuItem();
            this.itemxoanhansu = new System.Windows.Forms.ToolStripMenuItem();
            this.itemhuongdansudung = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgbNS)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgbNS
            // 
            this.dgbNS.AllowUserToAddRows = false;
            this.dgbNS.AllowUserToDeleteRows = false;
            this.dgbNS.AllowUserToResizeColumns = false;
            this.dgbNS.AllowUserToResizeRows = false;
            this.dgbNS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbNS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbNS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbNS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgbNS.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgbNS.Location = new System.Drawing.Point(0, 25);
            this.dgbNS.Name = "dgbNS";
            this.dgbNS.Size = new System.Drawing.Size(1161, 497);
            this.dgbNS.TabIndex = 1;
            // 
            // itemhethong
            // 
            this.itemhethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemdangnhap});
            this.itemhethong.Name = "itemhethong";
            this.itemhethong.Size = new System.Drawing.Size(74, 21);
            this.itemhethong.Text = "Hệ thống";
            // 
            // itemdangnhap
            // 
            this.itemdangnhap.Name = "itemdangnhap";
            this.itemdangnhap.Size = new System.Drawing.Size(140, 22);
            this.itemdangnhap.Text = "Đăng nhập";
            this.itemdangnhap.Click += new System.EventHandler(this.itemdangnhap_Click);
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
            // ma
            // 
            this.ma.DataPropertyName = "ma";
            this.ma.FillWeight = 30F;
            this.ma.HeaderText = "Mã";
            this.ma.Name = "ma";
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.FillWeight = 54.63992F;
            this.hoten.HeaderText = "Họ tên";
            this.hoten.Name = "hoten";
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.FillWeight = 54.63992F;
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.FillWeight = 54.63992F;
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            // 
            // quequan
            // 
            this.quequan.DataPropertyName = "quequan";
            this.quequan.FillWeight = 54.63992F;
            this.quequan.HeaderText = "Quê quán";
            this.quequan.Name = "quequan";
            // 
            // dantoc
            // 
            this.dantoc.DataPropertyName = "dantoc";
            this.dantoc.FillWeight = 54.63992F;
            this.dantoc.HeaderText = "Dân tộc";
            this.dantoc.Name = "dantoc";
            // 
            // sodienthoai
            // 
            this.sodienthoai.DataPropertyName = "sodienthoai";
            this.sodienthoai.FillWeight = 54.63992F;
            this.sodienthoai.HeaderText = "Số điện thoại";
            this.sodienthoai.Name = "sodienthoai";
            // 
            // taikhoan
            // 
            this.taikhoan.DataPropertyName = "taikhoan";
            this.taikhoan.FillWeight = 54.63992F;
            this.taikhoan.HeaderText = "Tài khoản";
            this.taikhoan.Name = "taikhoan";
            // 
            // chucvu
            // 
            this.chucvu.DataPropertyName = "chucvu";
            this.chucvu.FillWeight = 54.63992F;
            this.chucvu.HeaderText = "Chức vụ";
            this.chucvu.Name = "chucvu";
            // 
            // luong
            // 
            this.luong.DataPropertyName = "luong";
            this.luong.FillWeight = 54.63992F;
            this.luong.HeaderText = "Lương";
            this.luong.Name = "luong";
            // 
            // phongban
            // 
            this.phongban.DataPropertyName = "phongban";
            this.phongban.FillWeight = 54.63992F;
            this.phongban.HeaderText = "Phòng ban";
            this.phongban.Name = "phongban";
            // 
            // hocvan
            // 
            this.hocvan.DataPropertyName = "hocvan";
            this.hocvan.FillWeight = 54.63992F;
            this.hocvan.HeaderText = "Học vấn";
            this.hocvan.Name = "hocvan";
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgbNS);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Sự";
            this.Activated += new System.EventHandler(this.frmmain_Activated);
            this.Load += new System.EventHandler(this.frmmain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbNS)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbNS;
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
    }
}