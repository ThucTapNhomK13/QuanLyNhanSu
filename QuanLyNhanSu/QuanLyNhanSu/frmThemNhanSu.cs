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

        private bool XuLyDuLieu ()
        {

            if (!XuLyChuoi.KiemTraMa(txtMatKhau.Text))
            {
                lblMa.Text = "Lỗi";
                return false;
            }

            if (!XuLyChuoi.KiemTraHoTen(txtHoTen.Text))
            {
                lblHoTen.Text = "Lỗi";
                return false;
            }

            if (!XuLyChuoi.KiemTraSDT(txtSDT.Text))
            {
                lblSDT.Text = "Lỗi";
                return false;
            }

            if (!XuLyChuoi.KiemTraTaiKhoan(txtTaiKhoan.Text))
            {
                lblTK.Text = "Lỗi";
                return false;
            }
            return true;
        }

        public void LoadLuong()
        {
            DataProvider dp = new DataProvider();
            string sql = "select luongcoban from luong";
            DataTable dt = new DataTable();
            dt = dp.GetData(sql);
            cmbLuong.DataSource = dt;
            cmbLuong.DisplayMember = "luongcoban";
            cmbLuong.ValueMember = "luongcoban";
        }
        public void LoadPhongBan()
        {
            DataProvider dp = new DataProvider();
            string sql = "select ma, tenphongban from phongban";
            DataTable dt = new DataTable();
            dt = dp.GetData(sql);
            cmbPhongBan.DataSource = dt;
            cmbPhongBan.DisplayMember = "tenphongban";
            cmbPhongBan.ValueMember = "ma";
        }

        public void LoadHocVan()
        {
            DataProvider dp = new DataProvider();
            string sql = "select ma, tentrinhdohocvan from trinhdohocvan";
            DataTable dt = new DataTable();
            dt = dp.GetData(sql);
            cmbHocVan.DataSource = dt;
            cmbHocVan.DisplayMember = "tentrinhdohocvan";
            cmbHocVan.ValueMember = "ma";
        }
        public void LoadChucVu()
        {
            DataProvider dp = new DataProvider();
            string sql = "select ma, tenchucvu from chucvu";
            DataTable dt = new DataTable();
            dt = dp.GetData(sql);
            cmbChucVu.DataSource = dt;
            cmbPhongBan.DisplayMember = "tenchucvu";
            cmbChucVu.ValueMember = "ma";
        }
        private void frmThemNhanSu_Load(object sender, EventArgs e)
        {
            LoadLuong();
            LoadPhongBan();
            LoadHocVan();
            LoadChucVu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!XuLyDuLieu())
                return;
            // ma hoten ngaysinh quequan gioitinh dantoc sodienthoai taikhoan matkhau chucvuma luongcoban phongbanma trinhdohocvanma
            DataProvider dbCon = new DataProvider();

            string sqlQuery = "INSERT INTO nhanvien(hoten, ngaysinh, quequan, gioitinh, dantoc, sodienthoai, taikhoan, matkhau, chucvuma, luongcoban, phongbanma, trinhdohocvanma) ";
            sqlQuery += " VALUES ( @hoten, @ngaysinh, @quequan, @gioitinh, @dantoc, @sodienthoai, @taikhoan, @matkhau, @chucvuma, @luongcoban, @phongbanma, @trinhdohocvanma ) ";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@hoten", txtHoTen.Text);
            parameters.Add("@ngaysinh", datngaysinh.Text.ToString());
            parameters.Add("@quequan",cmbQueQuan.Text);
            if(chkNam.Checked)
                parameters.Add("@gioitinh", chkNam.Text);
            else
                parameters.Add("@gioitinh", chkNu.Text);
            parameters.Add("@dantoc", cmbDanToc.Text);
            parameters.Add("@sodienthoai", txtSDT.Text);
            parameters.Add("@taikhoan", txtTaiKhoan.Text);
            parameters.Add("@matkhau", txtMatKhau.Text);
            parameters.Add("@chucvuma", cmbChucVu.SelectedValue.ToString());
            parameters.Add("@luongcoban", cmbLuong.SelectedValue.ToString());
            parameters.Add("@phongbanma", cmbPhongBan.SelectedValue.ToString());
            parameters.Add("@trinhdohocvanma", cmbHocVan.SelectedValue.ToString());

            if (dbCon.InsertUpdateDelete(sqlQuery, parameters, false))
                MessageBox.Show("Thêm thành công!", "Thông báo");
            else
                MessageBox.Show("Thêm không thành công!", "Lỗi");

            this.Close();
        }

        private void txtHoTen_MouseClick(object sender, MouseEventArgs e)
        {
            txtHoTen.Clear();
            lblHoTen.Text = "";
        }

        private void txtSDT_MouseClick(object sender, MouseEventArgs e)
        {
            txtSDT.Clear();
            lblSDT.Text = "";
        }

        private void txtTaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            txtTaiKhoan.Clear();
            lblTK.Text = "";
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

        private void txtMa_Click(object sender, EventArgs e)
        {
            txtMatKhau.Clear();
            lblMa.Text = "";
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
