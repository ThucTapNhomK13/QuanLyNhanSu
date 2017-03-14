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
    public partial class frmThemNhanSu : Form
    {
        public frmThemNhanSu()
        {
            InitializeComponent();
        }

        private void frmThemNhanSu_Load(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            string sql = "select tenphongban from phongban";
            DataTable dt = new DataTable();
            dt = dp.GetData(sql);
            cmbPhongBan.DataSource = dt;
            cmbPhongBan.DisplayMember = "tenphongban";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // ma hoten ngaysinh quequan gioitinh dantoc sodienthoai taikhoan matkhau chucvuma luongcoban phongbanma trinhdohocvanma
            DataProvider dbCon = new DataProvider();

            string sqlQuery = "INSERT INTO nhanvien ";
            sqlQuery += "(ma, hoten, ngaysinh, quequan, gioitinh, dantoc, sodienthoai)";
            //sqlQuery += ", taikhoan,chucvuma, luongcoban, phongbanma, trinhdohocvanma) ";
            sqlQuery += "VALUES (@ma, @hoten, @ngaysinh, @quequan, @gioitinh, @dantoc, @sodienthoai)";
            //sqlQuery += " , @taikhoan,@chucvuma, @luongcoban, @phongbanma, @trinhdohocvan ) ";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ma", txtMa.Text);
            parameters.Add("@hoten", txtHoTen.Text);
            parameters.Add("@ngaysinh", datngaysinh.Text.ToString());
            parameters.Add("@quequan",cmbQueQuan.Text);
            if(chkNam.Checked)
                parameters.Add("@gioitinh", chkNam.Text);
            else
                parameters.Add("@gioitinh", chkNu.Text);
            parameters.Add("@dantoc", cmbDanToc.Text);
            parameters.Add("@sodienthoai", txtSDT.Text);
            //parameters.Add("@taikhoan", txtTaiKhoan.Text);
            //if(cmbChucVu.Text.ToString() == "Giám đốc")
            //{
            //    parameters.Add("@chucvuma", "CV01");
            //}

            
            //parameters.Add("@luongcoban", txtLuong.Text.ToString());
            //parameters.Add("@phongbanma", cmbPhongBan.Text);
            //parameters.Add("@trinhdohocvanma", txtHocVan.Text);

            //MessageBox.Show(datngaysinh.Text);

            if (dbCon.InsertUpdateDelete(sqlQuery, parameters, false))
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Close();
        }

        private void txtHoTen_MouseClick(object sender, MouseEventArgs e)
        {
            txtHoTen.Clear();
        }

        private void txtSDT_MouseClick(object sender, MouseEventArgs e)
        {
            txtSDT.Clear();
        }

        private void txtTaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            txtTaiKhoan.Clear();
        }

        private void txtLuong_MouseClick(object sender, MouseEventArgs e)
        {
            txtLuong.Clear();
        }

        private void txtHocVan_MouseClick(object sender, MouseEventArgs e)
        {
            txtHocVan.Clear();
        }

        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {
            if(chkNam.Checked)
            {
                chkNu.Checked = false;
            }
        }

        private void chkNu_CheckedChanged(object sender, EventArgs e)
        {
            if(chkNu.Checked)
            {
                chkNam.Checked = false;
            }
        }

        private void txtHoTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string hoten = XuLyChuoi.chuanhoa(txtHoTen.Text.ToString());
                txtHoTen.Text = hoten;
                datngaysinh.Focus();
            }
        }
    }
}
