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

using QuanLyNhanSu.BUS;
using QuanLyNhanSu.Model;

namespace QuanLyNhanSu
{
    public partial class frmThemNhanSu : Form
    {
        public frmThemNhanSu()
        {
            InitializeComponent();
        }

        private void LoadChucVu ()
        {
            cmbChucVu.DataSource = ChucVuBUS.Instance.GetAll();
            cmbChucVu.DisplayMember = "TenChucVu";
            cmbChucVu.ValueMember = "Ma";
        }

        private void LoadHocVan ()
        {
            cmbHocVan.DataSource = HocVanBUS.Instance.GetAll();
            cmbHocVan.DisplayMember = "TrinhDoHocVan";
            cmbHocVan.ValueMember = "Ma";
        }

        private void LoadPhongBan ()
        {
            cmbPhongBan.DataSource = PhongBanBUS.Instance.GetAll();
            cmbPhongBan.DisplayMember = "TenPhongBan";
            cmbPhongBan.ValueMember = "Ma";
        }

        private NhanSu SetNhanSu ()
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


        private bool XuLyDuLieu ()
        {

            if (!XuLyChuoi.KiemTraMa(txtMa.Text))
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
        private void frmThemNhanSu_Load(object sender, EventArgs e)
        {
            LoadChucVu();
            LoadHocVan();
            LoadPhongBan();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if (!XuLyDuLieu())
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
                NhanSu ns = SetNhanSu();
                if (NhanSuBUS.Instance.CheckId(ns.Ma))
                {
                    if (NhanSuBUS.Instance.Insert(ns))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtMa.Focus();
       
            
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

        private void txtLuong_MouseClick(object sender, MouseEventArgs e)
        {
            txtLuong.Clear();
        }

        
        private void txtMa_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
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
