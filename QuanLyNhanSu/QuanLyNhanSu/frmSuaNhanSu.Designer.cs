namespace QuanLyNhanSu
{
    partial class frmSuaNhanSu
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
            this.cmbPhongBan = new System.Windows.Forms.ComboBox();
            this.cmbChucVu = new System.Windows.Forms.ComboBox();
            this.cmbDanToc = new System.Windows.Forms.ComboBox();
            this.chkNu = new System.Windows.Forms.CheckBox();
            this.chkNam = new System.Windows.Forms.CheckBox();
            this.cmbQueQuan = new System.Windows.Forms.ComboBox();
            this.datngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtHocVan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbPhongBan
            // 
            this.cmbPhongBan.FormattingEnabled = true;
            this.cmbPhongBan.Location = new System.Drawing.Point(706, 260);
            this.cmbPhongBan.Name = "cmbPhongBan";
            this.cmbPhongBan.Size = new System.Drawing.Size(291, 21);
            this.cmbPhongBan.TabIndex = 57;
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
            this.cmbChucVu.Location = new System.Drawing.Point(706, 153);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Size = new System.Drawing.Size(291, 21);
            this.cmbChucVu.Sorted = true;
            this.cmbChucVu.TabIndex = 56;
            this.cmbChucVu.Text = "Giám đốc";
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
            this.cmbDanToc.Location = new System.Drawing.Point(128, 260);
            this.cmbDanToc.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDanToc.Name = "cmbDanToc";
            this.cmbDanToc.Size = new System.Drawing.Size(337, 24);
            this.cmbDanToc.Sorted = true;
            this.cmbDanToc.TabIndex = 55;
            this.cmbDanToc.Text = "Kinh";
            // 
            // chkNu
            // 
            this.chkNu.AutoSize = true;
            this.chkNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNu.Location = new System.Drawing.Point(264, 209);
            this.chkNu.Margin = new System.Windows.Forms.Padding(4);
            this.chkNu.Name = "chkNu";
            this.chkNu.Size = new System.Drawing.Size(44, 20);
            this.chkNu.TabIndex = 54;
            this.chkNu.Text = "Nữ";
            this.chkNu.UseVisualStyleBackColor = true;
            // 
            // chkNam
            // 
            this.chkNam.AutoSize = true;
            this.chkNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNam.Location = new System.Drawing.Point(128, 209);
            this.chkNam.Margin = new System.Windows.Forms.Padding(4);
            this.chkNam.Name = "chkNam";
            this.chkNam.Size = new System.Drawing.Size(56, 20);
            this.chkNam.TabIndex = 53;
            this.chkNam.Text = "Nam";
            this.chkNam.UseVisualStyleBackColor = true;
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
            this.cmbQueQuan.Location = new System.Drawing.Point(706, 44);
            this.cmbQueQuan.Margin = new System.Windows.Forms.Padding(4);
            this.cmbQueQuan.Name = "cmbQueQuan";
            this.cmbQueQuan.Size = new System.Drawing.Size(291, 24);
            this.cmbQueQuan.Sorted = true;
            this.cmbQueQuan.TabIndex = 52;
            this.cmbQueQuan.Text = "Hà Nội";
            // 
            // datngaysinh
            // 
            this.datngaysinh.CustomFormat = "MM/dd/yyyy";
            this.datngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datngaysinh.Location = new System.Drawing.Point(128, 156);
            this.datngaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.datngaysinh.MaxDate = new System.DateTime(2000, 12, 12, 0, 0, 0, 0);
            this.datngaysinh.MinDate = new System.DateTime(1975, 1, 1, 0, 0, 0, 0);
            this.datngaysinh.Name = "datngaysinh";
            this.datngaysinh.Size = new System.Drawing.Size(337, 22);
            this.datngaysinh.TabIndex = 51;
            this.datngaysinh.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // txtHocVan
            // 
            this.txtHocVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocVan.Location = new System.Drawing.Point(706, 314);
            this.txtHocVan.Margin = new System.Windows.Forms.Padding(4);
            this.txtHocVan.Name = "txtHocVan";
            this.txtHocVan.Size = new System.Drawing.Size(291, 22);
            this.txtHocVan.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(570, 318);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 16);
            this.label12.TabIndex = 49;
            this.label12.Text = "Trình độ học vấn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(570, 264);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 48;
            this.label11.Text = "Phòng ban";
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.Location = new System.Drawing.Point(706, 206);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(291, 22);
            this.txtLuong.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(570, 210);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 46;
            this.label10.Text = "Lương cơ bản";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(570, 156);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "Chức vụ";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(706, 98);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(291, 22);
            this.txtTaiKhoan.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(570, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "Tài khoản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(570, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Quê quán";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(128, 318);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(337, 22);
            this.txtSDT.TabIndex = 41;
            this.txtSDT.Text = "09865432";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 318);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Dân tộc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Ngày sinh";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(128, 102);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(337, 22);
            this.txtHoTen.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Họ tên";
            // 
            // txtMa
            // 
            this.txtMa.Enabled = false;
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(128, 47);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(337, 22);
            this.txtMa.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Mã";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(346, 391);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 37);
            this.btnThoat.TabIndex = 59;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(128, 391);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 37);
            this.btnThem.TabIndex = 58;
            this.btnThem.Text = "Sửa";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmSuaNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 476);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cmbPhongBan);
            this.Controls.Add(this.cmbChucVu);
            this.Controls.Add(this.cmbDanToc);
            this.Controls.Add(this.chkNu);
            this.Controls.Add(this.chkNam);
            this.Controls.Add(this.cmbQueQuan);
            this.Controls.Add(this.datngaysinh);
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
            this.Name = "frmSuaNhanSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa Thông Tin Nhân Viên";
            this.Load += new System.EventHandler(this.frmSuaNhanSu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPhongBan;
        private System.Windows.Forms.ComboBox cmbChucVu;
        private System.Windows.Forms.ComboBox cmbDanToc;
        private System.Windows.Forms.CheckBox chkNu;
        private System.Windows.Forms.CheckBox chkNam;
        private System.Windows.Forms.ComboBox cmbQueQuan;
        private System.Windows.Forms.DateTimePicker datngaysinh;
        private System.Windows.Forms.TextBox txtHocVan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
    }
}