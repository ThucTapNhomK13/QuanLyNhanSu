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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnNewTab = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(0, 28);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 25);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(46, 28);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 25);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(92, 30);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(642, 20);
            this.txtUrl.TabIndex = 2;
            this.txtUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrl_KeyPress);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGo.FlatAppearance.BorderSize = 0;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Location = new System.Drawing.Point(749, 30);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(43, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnNewTab
            // 
            this.btnNewTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNewTab.FlatAppearance.BorderSize = 0;
            this.btnNewTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTab.Location = new System.Drawing.Point(802, 30);
            this.btnNewTab.Name = "btnNewTab";
            this.btnNewTab.Size = new System.Drawing.Size(91, 23);
            this.btnNewTab.TabIndex = 4;
            this.btnNewTab.Text = "New Tab";
            this.btnNewTab.UseVisualStyleBackColor = false;
            this.btnNewTab.Click += new System.EventHandler(this.btnNewTab_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(3, 59);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(878, 422);
            this.tabControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(870, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(864, 390);
            this.webBrowser.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 24);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(870, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(847, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmHuongDanSuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 493);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnNewTab);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnGo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHuongDanSuDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hướng Dẫn Sử Dụng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHuongDanSuDung_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnNewTab;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}