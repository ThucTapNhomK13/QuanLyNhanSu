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
            string querry = "select count(*) from nhanvien where taikhoan = @taikhoan and matkhau = @matkhau";
            SqlConnection cn = new SqlConnection(connectionstring.chuoiketnoi);
            SqlCommand cm = new SqlCommand();
            cm.CommandText = querry;
            cm.Connection = cn;
            cm.Parameters.Add(new SqlParameter("@taikhoan", txttentruycap.Text));
            cm.Parameters.Add(new SqlParameter("@matkhau", txtmatkhau.Text));
            cn.Open();
            int ret = (int)cm.ExecuteScalar();
            cn.Close();
            if (ret <= 0)
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
        
        private void txttentruycap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 9)
            {
                txtmatkhau.Focus();
            }
        }

        private void txttentruycap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtmatkhau.Focus();
            }
        }

        private void txtmatkhau_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                txttentruycap.Focus();
            }
        }

        private void txtmatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btndangnhap_Click(sender, e);
            }
        }
    }
}
