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
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {

            //string querry = "select count(*) from nhanvien where taikhoan = @taikhoan and matkhau = @matkhau";
            //SqlConnection cn = new SqlConnection(connectionstring.chuoiketnoi);
            //SqlCommand cm = new SqlCommand();
            //cm.CommandText = querry;
            //cm.Connection = cn;
            //cm.Parameters.Add(new SqlParameter("@taikhoan", txttentruycap.Text));
            //cm.Parameters.Add(new SqlParameter("@matkhau", txtmatkhau.Text));
            //cn.Open();
            //int ret = (int)cm.ExecuteScalar();
            //cn.Close();
            //if (ret <= 0)
            //{
            //    MessageBox.Show("Đăng nhập không thành công!");
            //}
            //else
            //{
            //    this.Close();
            //}

            DataProvider dp = new DataProvider();

            string sqlQuery = " select count(*) from nhanvien ";
            sqlQuery += " where taikhoan = @taikhoan and matkhau = @matkhau ";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@taikhoan", txttentruycap.Text);
            parameters.Add("@matkhau", txtmatkhau.Text);

            // Đếm 
            int i = dp.Select(sqlQuery, false, parameters).Rows.Count ;

            if (i > 0)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }  
            else
                MessageBox.Show("Tên người dùng hoặc mật khảu sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
