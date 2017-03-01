namespace QuanLyNhanSu
{
    partial class frmHuongDanSuDung
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Tìm kiếm nhân sự");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Thêm nhân sự mới");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Sửa thông tin nhân sự");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Xóa nhân sự");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nhân viên", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node8";
            treeNode1.Text = "Tìm kiếm nhân sự";
            treeNode2.Name = "Node9";
            treeNode2.Text = "Thêm nhân sự mới";
            treeNode3.Name = "Node10";
            treeNode3.Text = "Sửa thông tin nhân sự";
            treeNode4.Name = "Node12";
            treeNode4.Text = "Xóa nhân sự";
            treeNode5.Name = "";
            treeNode5.Text = "Nhân viên";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(212, 506);
            this.treeView1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(212, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(837, 506);
            this.webBrowser1.TabIndex = 1;
            // 
            // frmHuongDanSuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 506);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.treeView1);
            this.Name = "frmHuongDanSuDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hướng Dẫn Sử Dụng";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}