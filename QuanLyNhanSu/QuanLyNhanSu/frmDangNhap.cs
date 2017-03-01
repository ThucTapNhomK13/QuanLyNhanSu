﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            DataProvider dt = new DataProvider();
            SqlParameter[] pa = new SqlParameter[]
            {
                new SqlParameter("@taikhoan", txttentruycap.Text),
                new SqlParameter("@matkhau", txtmatkhau.Text)
            };

            int ret = dt.DangNhap("select count(*) from nhanvien where taikhoan = @taikhoan and matkhau = @matkhau", pa);
            if(ret < 0)
            {
                MessageBox.Show("Đăng nhập không thành công!");
            }
            else
            {
                this.Close();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool mv;
        int x, y;
        private void frmdangnhap_MouseUp(object sender, MouseEventArgs e)
        {
            mv = false;
        }

        private void frmdangnhap_MouseDown(object sender, MouseEventArgs e)
        {
            mv = true;
            x = e.X;
            y = e.Y;
        }

        private void frmdangnhap_MouseMove(object sender, MouseEventArgs e)
        {
            if (mv)
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
        }
    }
}
