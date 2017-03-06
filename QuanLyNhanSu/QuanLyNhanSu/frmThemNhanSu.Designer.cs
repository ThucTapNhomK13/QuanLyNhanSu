namespace QuanLyNhanSu
{
    partial class frmThemNhanSu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHocVan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.datngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cmbQueQuan = new System.Windows.Forms.ComboBox();
            this.chkNam = new System.Windows.Forms.CheckBox();
            this.chkNu = new System.Windows.Forms.CheckBox();
            this.cmbDanToc = new System.Windows.Forms.ComboBox();
            this.cmbChucVu = new System.Windows.Forms.ComboBox();
            this.cmbPhongBan = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(163, 55);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(337, 22);
            this.txtMa.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(163, 110);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(337, 22);
            this.txtHoTen.TabIndex = 3;
            this.txtHoTen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtHoTen_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dân tộc";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(163, 326);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(337, 22);
            this.txtSDT.TabIndex = 11;
            this.txtSDT.Text = "09865432";
            this.txtSDT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSDT_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 326);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(605, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quê quán";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(741, 106);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(291, 22);
            this.txtTaiKhoan.TabIndex = 15;
            this.txtTaiKhoan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTaiKhoan_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(605, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tài khoản";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(605, 164);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Chức vụ";
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.Location = new System.Drawing.Point(741, 214);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(291, 22);
            this.txtLuong.TabIndex = 19;
            this.txtLuong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLuong_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(605, 218);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Lương cơ bản";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(605, 272);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Phòng ban";
            // 
            // txtHocVan
            // 
            this.txtHocVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocVan.Location = new System.Drawing.Point(741, 322);
            this.txtHocVan.Margin = new System.Windows.Forms.Padding(4);
            this.txtHocVan.Name = "txtHocVan";
            this.txtHocVan.Size = new System.Drawing.Size(291, 22);
            this.txtHocVan.TabIndex = 23;
            this.txtHocVan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtHocVan_MouseClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(605, 326);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Trình độ học vấn";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(62, 398);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 37);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(267, 398);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 37);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // datngaysinh
            // 
            this.datngaysinh.CustomFormat = "MM/dd/yyyy";
            this.datngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datngaysinh.Location = new System.Drawing.Point(163, 164);
            this.datngaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.datngaysinh.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.datngaysinh.MinDate = new System.DateTime(1975, 1, 1, 0, 0, 0, 0);
            this.datngaysinh.Name = "datngaysinh";
            this.datngaysinh.Size = new System.Drawing.Size(337, 22);
            this.datngaysinh.TabIndex = 26;
            this.datngaysinh.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // cmbQueQuan
            // 
            this.cmbQueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQueQuan.FormattingEnabled = true;
            this.cmbQueQuan.Items.AddRange(new object[] {
            "Bắc Ninh",
            "Hà Nam",
            "Hà Nội",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng",
            "Hòa Bình",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Quảng Bình",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.cmbQueQuan.Location = new System.Drawing.Point(741, 52);
            this.cmbQueQuan.Margin = new System.Windows.Forms.Padding(4);
            this.cmbQueQuan.Name = "cmbQueQuan";
            this.cmbQueQuan.Size = new System.Drawing.Size(291, 24);
            this.cmbQueQuan.Sorted = true;
            this.cmbQueQuan.TabIndex = 27;
            this.cmbQueQuan.Text = "Hà Nội";
            // 
            // chkNam
            // 
            this.chkNam.AutoSize = true;
            this.chkNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNam.Location = new System.Drawing.Point(163, 217);
            this.chkNam.Margin = new System.Windows.Forms.Padding(4);
            this.chkNam.Name = "chkNam";
            this.chkNam.Size = new System.Drawing.Size(56, 20);
            this.chkNam.TabIndex = 28;
            this.chkNam.Text = "Nam";
            this.chkNam.UseVisualStyleBackColor = true;
            this.chkNam.CheckedChanged += new System.EventHandler(this.chkNam_CheckedChanged);
            // 
            // chkNu
            // 
            this.chkNu.AutoSize = true;
            this.chkNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNu.Location = new System.Drawing.Point(299, 217);
            this.chkNu.Margin = new System.Windows.Forms.Padding(4);
            this.chkNu.Name = "chkNu";
            this.chkNu.Size = new System.Drawing.Size(44, 20);
            this.chkNu.TabIndex = 29;
            this.chkNu.Text = "Nữ";
            this.chkNu.UseVisualStyleBackColor = true;
            this.chkNu.CheckedChanged += new System.EventHandler(this.chkNu_CheckedChanged);
            // 
            // cmbDanToc
            // 
            this.cmbDanToc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDanToc.FormattingEnabled = true;
            this.cmbDanToc.Items.AddRange(new object[] {
            "Kinh",
            "Mường",
            "Tày",
            "Thái"});
            this.cmbDanToc.Location = new System.Drawing.Point(163, 268);
            this.cmbDanToc.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDanToc.Name = "cmbDanToc";
            this.cmbDanToc.Size = new System.Drawing.Size(337, 24);
            this.cmbDanToc.Sorted = true;
            this.cmbDanToc.TabIndex = 30;
            this.cmbDanToc.Text = "Kinh";
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.FormattingEnabled = true;
            this.cmbChucVu.Items.AddRange(new object[] {
            "Giám đốc",
            "Nhân viên",
            "Phó giám đốc",
            "Phó phòng",
            "Trưởng phòng"});
            this.cmbChucVu.Location = new System.Drawing.Point(741, 161);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Size = new System.Drawing.Size(291, 24);
            this.cmbChucVu.Sorted = true;
            this.cmbChucVu.TabIndex = 31;
            this.cmbChucVu.Text = "Giám đốc";
            // 
            // cmbPhongBan
            // 
            this.cmbPhongBan.FormattingEnabled = true;
            this.cmbPhongBan.Location = new System.Drawing.Point(741, 268);
            this.cmbPhongBan.Name = "cmbPhongBan";
            this.cmbPhongBan.Size = new System.Drawing.Size(291, 24);
            this.cmbPhongBan.TabIndex = 32;
            // 
            // frmThemNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 471);
            this.Controls.Add(this.cmbPhongBan);
            this.Controls.Add(this.cmbChucVu);
            this.Controls.Add(this.cmbDanToc);
            this.Controls.Add(this.chkNu);
            this.Controls.Add(this.chkNam);
            this.Controls.Add(this.cmbQueQuan);
            this.Controls.Add(this.datngaysinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtHocVan);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThemNhanSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm Nhân Sự Mới";
            this.Load += new System.EventHandler(this.frmThemNhanSu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHocVan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DateTimePicker datngaysinh;
        private System.Windows.Forms.ComboBox cmbQueQuan;
        private System.Windows.Forms.CheckBox chkNam;
        private System.Windows.Forms.CheckBox chkNu;
        private System.Windows.Forms.ComboBox cmbDanToc;
        private System.Windows.Forms.ComboBox cmbChucVu;
        private System.Windows.Forms.ComboBox cmbPhongBan;
    }
}