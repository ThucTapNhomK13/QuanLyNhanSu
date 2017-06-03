using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QuanLyNhanSu.BUS;
using QuanLyNhanSu.Model;

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
            txtMa.Enabled = false;
        }

        private void LoadChucVu()
        {
            cmbChucVu.DataSource = ChucVuBUS.Instance.GetAll();
            cmbChucVu.DisplayMember = "TenChucVu";
            cmbChucVu.ValueMember = "Ma";
        }

        private void LoadHocVan()
        {
            cmbHocVan.DataSource = HocVanBUS.Instance.GetAll();
            cmbHocVan.DisplayMember = "TrinhDoHocVan";
            cmbHocVan.ValueMember = "Ma";
        }

        private void LoadPhongBan()
        {
            cmbPhongBan.DataSource = PhongBanBUS.Instance.GetAll();
            cmbPhongBan.DisplayMember = "TenPhongBan";
            cmbPhongBan.ValueMember = "Ma";
        }

        private void GetById ()
        {
            NhanSu ns = NhanSuBUS.Instance.GetById(_id);

            txtMa.Text = ns.Ma;
            txtHoTen.Text = ns.HoTen;
            datngaysinh.Value = DateTime.Parse(ns.NgaySinh.ToString());
            cmbQueQuan.DisplayMember = ns.QueQuan;
            cmbDanToc.DisplayMember = ns.DanToc;
            txtSDT.Text = ns.SoDienThoai;
            txtTaiKhoan.Text = ns.TaiKhoan;
            if (ns.GioiTinh == "Nam" || ns.GioiTinh == "nam")
            {
                chkNam.Checked = true;
            }
            else
                chkNu.Checked = true;

            txtLuong.Text = ns.LuongConBan.ToString();
            //cmbPhongBan.DisplayMember = HocVanBUS.Instance.GetByName(ns.PhongBanMa);
            //cmbChucVu.DisplayMember = ChucVuBUS.Instance.GetByName(ns.ChuVuMa);
            //cmbHocVan.DisplayMember = HocVanBUS.Instance.GetByName(ns.HocVanMa);
        }

        private NhanSu SetNhanSu()
        {
            NhanSu ns = new NhanSu();
            ns.Ma = txtMa.Text.Trim();
            ns.HoTen = txtHoTen.Text.Trim();
            ns.NgaySinh = datngaysinh.Value;
            ns.QueQuan = cmbQueQuan.SelectedItem as string;
            ns.DanToc = cmbDanToc.SelectedItem as string;
            ns.SoDienThoai = txtSDT.Text.Trim();
            ns.TaiKhoan = txtTaiKhoan.Text.Trim();
            ns.GioiTinh = chkNam.Checked ? chkNam.Text : chkNu.Text;

            ns.LuongConBan = float.Parse(txtLuong.Text.Trim());
            ns.PhongBanMa = (cmbPhongBan.SelectedItem as PhongBan).Ma;
            ns.ChuVuMa = (cmbChucVu.SelectedItem as ChucVu).Ma;
            ns.HocVanMa = (cmbHocVan.SelectedItem as HocVan).Ma;

            return ns;
        }

        private void frmSuaNhanSu_Load(object sender, EventArgs e)
        {
            GetById();
            LoadHocVan();
            LoadChucVu();
            LoadPhongBan();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (NhanSuBUS.Instance.Update(SetNhanSu()))
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
            }
        }
    }
}
