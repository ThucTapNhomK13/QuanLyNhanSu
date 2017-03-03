using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // ma ten ngaysinh quequan gioitinh dantoc sodienthoai taikhoan matkhau chucvu luong phongban hocvan
            DataProvider dbCon = new DataProvider();

            string sqlQuery = "INSERT INTO nhanvien  (ma, hoten, ngaysinh, quequan, gioitinh, dantoc, sodienthoai, taikhoan) ";
            sqlQuery += " VALUES (@ma, @hoten, @ngaysinh, @quequan, @gioitinh, @dantoc, @sodienthoai, @taikhoan) ";

            //string sqlQuery = "INSERT INTO [nhanvien] ";
            //sqlQuery += " (ma, hoten, ngaysinh, quequan, gioitinh, dantoc, sodienthoai, taikhoan) "; //, chucvuma, luongcoban, phongbanma, trinhdohocvanma ) ";
            //sqlQuery += " VALUES ";
            //sqlQuery += " (@ma, @hoten, @ngaysinh, @quequan, @gioitinh, @dantoc, @sodienthoai, @taikhoan ) ";//, @chucvuma, @luongcoban, @phongbanma, @trinhdohocvanma )";


            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ma", txtMa.Text);
            parameters.Add("@hoten", txtHoTen.Text);
            parameters.Add("@ngaysinh", datngaysinh.ToString());
            parameters.Add("@quequan",cmbQueQuan.Text);
            if(chkNam.Checked)
                parameters.Add("@gioitinh", chkNam.Text);
            else
                parameters.Add("@gioitinh", chkNu.Text);
            parameters.Add("@dantoc", cmbDanToc.Text);
            parameters.Add("@sodienthoai", txtSDT.Text);
            parameters.Add("@taikhoan", txtTaiKhoan.Text);
            //parameters.Add("@chucvuma", cmbChucVu.Text);
            //parameters.Add("@luongcoban", txtLuong.Text);
            //parameters.Add("@phongbanma", cmbPhongBan.Text);
            //parameters.Add("@trinhdohocvanma", txtHocVan.Text);

            if (dbCon.InsertUpdateDelete(sqlQuery, parameters, false))
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Close();
        }

        private void txtNgaySinh_MouseClick(object sender, MouseEventArgs e)
        {
           
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
    }
}
