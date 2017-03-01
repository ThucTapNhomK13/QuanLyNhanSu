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
            DatabaseA dbCon = new DatabaseA();

            string sqlQuery = "INSERT INTO nhanvien  (ma, hoten, ngaysinh, quequan, gioitinh, dantoc, sodienthoai, taikhoan) ";
            sqlQuery += " VALUES (@ma, @hoten, @ngaysinh, @quequan, @gioitinh, @dantoc, @sodienthoai, @taikhoan) ";

            //string sqlQuery = "INSERT INTO [nhanvien] ";
            //sqlQuery += " (ma, hoten, ngaysinh, quequan, gioitinh, dantoc, sodienthoai, taikhoan) "; //, chucvuma, luongcoban, phongbanma, trinhdohocvanma ) ";
            //sqlQuery += " VALUES ";
            //sqlQuery += " (@ma, @hoten, @ngaysinh, @quequan, @gioitinh, @dantoc, @sodienthoai, @taikhoan ) ";//, @chucvuma, @luongcoban, @phongbanma, @trinhdohocvanma )";


            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ma", txtMa.Text);
            parameters.Add("@hoten", txtHoTen.Text);
            parameters.Add("@ngaysinh", txtNgaySinh.Text);
            parameters.Add("@quequan", txtQueQuan.Text);
            parameters.Add("@gioitinh", txtGioiTinh.Text);
            parameters.Add("@dantoc", txtDanToc.Text);
            parameters.Add("@sodienthoai", txtSDT.Text);
            parameters.Add("@taikhoan", txtTaiKhoan.Text);
            //parameters.Add("@chucvuma", txtChucVu.Text);
            //parameters.Add("@luongcoban", txtLuong.Text);
            //parameters.Add("@phongbanma", txtPhongBan.Text);
            //parameters.Add("@trinhdohocvanma", txtHocVan.Text);

            if (dbCon.InsertUpdateDelete(sqlQuery, parameters, false))
                MessageBox.Show("Them thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Them that bai", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void txtNgaySinh_MouseClick(object sender, MouseEventArgs e)
        {
            //txtNgaySinh.Clear();
        }
    }
}
