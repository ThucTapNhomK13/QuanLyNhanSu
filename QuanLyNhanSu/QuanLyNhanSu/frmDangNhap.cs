using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using QuanLyNhanSu.Model;
using QuanLyNhanSu.BUS;

namespace QuanLyNhanSu
{
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }

        #region Event
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan(txttentruycap.Text.Trim(), txtmatkhau.Text.Trim());
            if (TaiKhoanBUS.Instance.DangNhap(tk))
            {
                this.Hide();
                frmmain frMain = new frmmain();
                frMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmatkhau.Clear();
                txttentruycap.Focus();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region TextBox
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
            if (e.KeyCode == Keys.Up)
            {
                txttentruycap.Focus();
            }
        }

        private void txtmatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btndangnhap_Click(sender, e);
            }
        }
        #endregion

        #region Di chuyeen
        bool mv;
        int x, y;
        private void frmdangnhap_MouseMove(object sender, MouseEventArgs e)
        {
            if (mv)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void frmdangnhap_MouseDown(object sender, MouseEventArgs e)
        {
            mv = true;
            x = e.X;
            y = e.Y;
        }

        private void frmdangnhap_MouseUp(object sender, MouseEventArgs e)
        {
            mv = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mv = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mv)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mv = false;
        }

        #endregion

    }
}
