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

namespace QuanLyNhanSu
{
    public partial class frmdangnhap : Form
    {
        public bool dangnhapthanhcong = false;
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            //if (txttentruycap.Text == "")
            //{
            //    MessageBox.Show("Bạn chưa nhập tên truy cập!", "Thông báo", MessageBoxButtons.OK);
            //    txttentruycap.Focus();
            //}
            //else if (txtmatkhau.Text == "")
            //{
            //    MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK);
            //    txtmatkhau.Focus();
            //}
            //else
            //{
            DataProvider dp = new DataProvider();

            string sqlQuery = "select * from nhanvien where taikhoan = @taikhoan and matkhau = @matkhau";

            //SqlParameter[] parameters = new SqlParameter[]
            //{
            //    new SqlParameter ("@taikhoan", txttentruycap.Text),
            //    new SqlParameter("@matkhau", txtmatkhau.Text)
            //};
            //int i = dp.DangNhap(sqlQuery, parameters);

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@taikhoan", txttentruycap.Text);
            parameters.Add("@matkhau", txtmatkhau.Text);

            // Đếm 

            int i = dp.Select(sqlQuery, false, parameters).Rows.Count;

            if (i == 1)
            {
                dangnhapthanhcong = true;
                this.Hide();
                frmmain frm = new frmmain();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttentruycap.Focus();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //bool mv;
        //int x, y;
        //private void frmdangnhap_MouseUp(object sender, MouseEventArgs e)
        //{
        //    mv = false;
        //}

        //private void frmdangnhap_MouseDown(object sender, MouseEventArgs e)
        //{
        //    mv = true;
        //    x = e.X;
        //    y = e.Y;
        //}

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
    }
}
