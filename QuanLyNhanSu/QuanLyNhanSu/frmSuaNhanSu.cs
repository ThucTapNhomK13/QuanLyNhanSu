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
    public partial class frmSuaNhanSu : Form
    {
        private int _id;
        public frmSuaNhanSu()
        {
            InitializeComponent();
        }

        public frmSuaNhanSu(int id) : this()
        {
            _id = id;
        }

        private DataRow GetDataTable()
        {
            DataProvider dbA = new DataProvider();

            string sqlQuery = " select ";
            sqlQuery += " ma, hoten, ngaysinh, quequan, gioitinh, dantoc, sodienthoai, taikhoan, chucvuma, luongcoban, phongbanma, trinhdohocvanma ";
            sqlQuery += " from nhanvien where ma = @ma ";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ma", _id);

            //DataTable dt = dbA.Select(sqlQuery, parameters, false);
            //return dt.Rows[0];
            // or 
            return dbA.Select(sqlQuery, false, parameters).AsEnumerable().First();
        }

        private void SelectNhanVien(DataRow dr)
        {
            // ma hoten ngaysinh quequan gioitinh dantoc sodienthoai taikhoan matkhau chucvuma luongcoban phongbanma trinhdohocvanma
            txtMa.Text = dr["ma"].ToString();
            txtHoTen.Text = dr["hoten"].ToString();
            datngaysinh.Text = dr["ngaysinh"].ToString();

            string gioitinh = dr["gioitinh"].ToString();
            if (gioitinh == "Nam" || gioitinh == "nam")
                chkNam.Checked = true;
            else
                chkNu.Checked = true;
            cmbDanToc.Text = dr["dantoc"].ToString();
            txtSDT.Text = dr["sodienthoai"].ToString();
            txtTaiKhoan.Text = dr["taikhoan"].ToString();
            cmbQueQuan.Text = dr["quequan"].ToString();
            cmbChucVu.SelectedValue = dr["chucvuma"].ToString();
            cmbLuong.SelectedValue = dr["luongcoban"].ToString();
            cmbPhongBan.SelectedValue = dr["phongbanma"].ToString();
            cmbHocVan.SelectedValue = dr["trinhdohocvanma"].ToString();
        }

        public void LoadcmbLuong()
        {
            DataProvider dp = new DataProvider();
            string sql = "select luongcoban from luong";
            DataTable dt = new DataTable();
            dt = dp.GetData(sql);
            cmbLuong.DataSource = dt;
            cmbLuong.DisplayMember = "luongcoban";
            cmbLuong.ValueMember = "luongcoban";
        }

        public void LoadcmbChucVu()
        {
            DataProvider dp = new DataProvider();
            string sql = "select * from chucvu";
            DataTable dt = new DataTable();
            dt = dp.GetData(sql);
            cmbChucVu.DataSource = dt;
            cmbChucVu.DisplayMember = "tenchucvu";
            cmbChucVu.ValueMember = "ma";
        }

        public void LoadcmbHocVan()
        {
            DataProvider dp = new DataProvider();
            string sql = "select ma, tentrinhdohocvan from trinhdohocvan";
            DataTable dt = new DataTable();
            dt = dp.GetData(sql);
            cmbHocVan.DataSource = dt;
            cmbHocVan.DisplayMember = "tentrinhdohocvan";
            cmbHocVan.ValueMember = "ma";
        }

        public void LoadcmbPhongBan()
        {
            DataProvider dp = new DataProvider();
            string sql = "select * from phongban";
            DataTable dt = new DataTable();
            dt = dp.GetData(sql);
            cmbPhongBan.DataSource = dt;
            cmbPhongBan.DisplayMember = "tenphongban";
            cmbPhongBan.ValueMember = "ma";
        }

        private void frmSuaNhanSu_Load(object sender, EventArgs e)
        {
            LoadcmbPhongBan();
            LoadcmbHocVan();
            LoadcmbLuong();
            LoadcmbChucVu();
            SelectNhanVien(GetDataTable());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataProvider dbA = new DataProvider();

            string sqlQuery = @"update nhanvien set hoten = @hoten, ngaysinh = @ngaysinh, quequan = @quequan, gioitinh = @gioitinh,  dantoc = @dantoc, sodienthoai = @sodienthoai, taikhoan = @taikhoan, chucvuma = @chucvuma, luongcoban = @luongcoban, phongbanma = @phongbanma,  trinhdohocvanma = @trinhdohocvanma where ma = @ma";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ma", txtMa.Text);
            parameters.Add("@hoten", txtHoTen.Text);
            parameters.Add("@ngaysinh", datngaysinh.Text.ToString());
            parameters.Add("@quequan", cmbQueQuan.Text);
            if (chkNam.Checked)
                parameters.Add("@gioitinh", chkNam.Text);
            else
                parameters.Add("@gioitinh", chkNu.Text);
            parameters.Add("@dantoc", cmbDanToc.Text);
            parameters.Add("@sodienthoai", txtSDT.Text);
            parameters.Add("@taikhoan", txtTaiKhoan.Text);
            parameters.Add("@chucvuma", cmbChucVu.SelectedValue.ToString());
            parameters.Add("@luongcoban", cmbLuong.SelectedValue.ToString());
            parameters.Add("@phongbanma", cmbPhongBan.SelectedValue.ToString());
            parameters.Add("@trinhdohocvanma", cmbHocVan.SelectedValue.ToString());

            if (dbA.InsertUpdateDelete(sqlQuery, parameters, false))
                MessageBox.Show("Sửa thành công!", "Thông báo");
            else
                MessageBox.Show("Sửa không thành công!", "Lỗi");
            this.Close();
        }
    }
}
