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
            ((System.ComponentModel.ISupportInitialize)(this.dgbNS)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgbNS
            // 
            this.dgbNS.AllowUserToAddRows = false;
            this.dgbNS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbNS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbNS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbNS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgbNS.Location = new System.Drawing.Point(0, 44);
            this.dgbNS.Name = "dgbNS";
            this.dgbNS.Size = new System.Drawing.Size(929, 387);
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
            this.itemdangnhap.Size = new System.Drawing.Size(152, 22);
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
            this.menuStrip1.Size = new System.Drawing.Size(929, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 19);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 431);
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
    }
}