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
        private string _id;
        public frmSuaNhanSu()
        {
            InitializeComponent();
        }

        public frmSuaNhanSu (string id) : this()
        {
            _id = id;
        }

        //private DataRow GetDataTable ()
        //{
        //    DataProvider dbA = new DataProvider();

        //    string sqlQuery = " select ";
        //    sqlQuery += " ma, hoten, ngaysinh, quequan, gioitinh, dantoc, sodienthoai, taikhoan, chucvuma, luongcoban, phongbanma, trinhdohocvanma ";
        //    sqlQuery += " from nhanvien where ma = @ma ";

        //    Dictionary<string, object> parameters = new Dictionary<string, object>();
        //    parameters.Add("@ma", _id);

        //    //DataTable dt = dbA.Select(sqlQuery, parameters, false);
        //    //return dt.Rows[0];
        //    // or 
        //    return dbA.Select(sqlQuery, false, parameters).AsEnumerable().First();
        //}

        //private void SelectID (DataRow dr)
        //{
        //    // ma hoten ngaysinh quequan gioitinh dantoc sodienthoai taikhoan matkhau chucvuma luongcoban phongbanma trinhdohocvanma
        //    txtMa.Text = dr["ma"].ToString();
        //    txtHoTen.Text = dr["hoten"].ToString();
        //    datngaysinh.Text = dr["ngaysinh"].ToString();

        //    string gioitinh = dr["gioitinh"].ToString();
        //    if (gioitinh == "Nam" || gioitinh == "nam")
        //        chkNam.Checked = true;
        //    else
        //        chkNu.Checked = true;

        //    cmbDanToc.Text = dr["dantoc"].ToString();
        //    txtSDT.Text = dr["sodienthoai"].ToString();
        //    txtTaiKhoan.Text = dr["taikhoan"].ToString();
        //    //cmbChucVu.Text = dr["chucvuma"].ToString();
        //    //txtLuong.Text = dr["luongcoban"].ToString();
        //    //cmbPhongBan.Text = dr["phongbanma"].ToString();
        //    //txtHocVan.Text = dr["trinhdohocvanma"].ToString();
        //}

        private void frmSuaNhanSu_Load(object sender, EventArgs e)
        {
            //SelectID(GetDataTable());
            ////DataProvider dp = new DataProvider();
            //string sql = "select tenphongban from phongban";
            //DataTable dt = new DataTable();
            //dt = DataProvider.GetData(sql);
            //cmbPhongBan.DataSource = dt;
            //cmbPhongBan.DisplayMember = "tenphongban";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //DataProvider dbA = new DataProvider();

            //string sqlQuery = " update nhanvien ";
            //sqlQuery += " set hoten=@hoten, ngaysinh=@ngaysinh, quequan=@quequan, gioitinh=@gioitinh, ";
            //sqlQuery += " dantoc=@dantoc, sodienthoai=@sdt, taikhoan=@taikhoan ";
            //sqlQuery += ", chucvuma=@chucvu,  luongcoban=@luong, phongbanma=@phongban, trinhdohocvanma=@hocvan ";
            //sqlQuery += " where ma=@ma";

            //Dictionary<string, object> parameters = new Dictionary<string, object>();
            //parameters.Add("@ma", txtMa.Text);
            //parameters.Add("@hoten", txtHoTen.Text);
            //parameters.Add("@ngaysinh", datngaysinh.Text);
            //parameters.Add("@quequan", cmbQueQuan.Text);
            //if (chkNam.Checked)
            //    parameters.Add("@gioitinh", chkNam.Text);
            //else
            //    parameters.Add("@gioitinh", chkNu.Text);
            //parameters.Add("@dantoc", cmbDanToc.Text);
            //parameters.Add("@sdt", txtSDT.Text);
            //parameters.Add("@taikhoan", txtTaiKhoan.Text);
            //parameters.Add("@chucvu", cmbChucVu.Text);
            //parameters.Add("@luong", txtLuong.Text);
            ////parameters.Add("@phongban", cmbPhongBan.Text);
            ////parameters.Add("@hocvan", txtHocVan.Text);

            //if (dbA.InsertUpdateDelete(sqlQuery, parameters, false))
            //    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //else
            //    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //this.Close();
        }
    }
}
