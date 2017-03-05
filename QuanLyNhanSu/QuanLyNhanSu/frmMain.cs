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
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void itemdangnhap_Click(object sender, EventArgs e)
        {
            frmdangnhap dn = new frmdangnhap();
            dn.ShowDialog();
        }

        private void itemtimkiem_Click(object sender, EventArgs e)
        {
            frmTimKiem tk = new frmTimKiem();
            tk.ShowDialog();
        }

        private void itemthemnhansumoi_Click(object sender, EventArgs e)
        {
            frmThemNhanSu frmthem = new frmThemNhanSu();
            frmthem.ShowDialog();
        }

        private void itemsuanhansu_Click(object sender, EventArgs e)
        {
            if (dgbNS.SelectedRows.Count > 0)
            {
                int selectIndex = dgbNS.SelectedRows[0].Index;
                // Lay ma trong datagridview o cot dau tien 
                string id = dgbNS[0, selectIndex].Value.ToString();
                frmSuaNhanSu frmsua = new frmSuaNhanSu(id);
                frmsua.ShowDialog();
            }
            
        }

        private void itemxoanhansu_Click(object sender, EventArgs e)
        {
            frmXoaNhanSu frmxoa = new frmXoaNhanSu();
            frmxoa.ShowDialog();
        }

        private void itemhuongdansudung_Click(object sender, EventArgs e)
        {
            frmHuongDanSuDung frmhd = new frmHuongDanSuDung();
            frmhd.ShowDialog();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            dgbNS.DataSource = GetData();
        }

        private DataTable GetData ()
        {
            DatabaseA dbA = new DatabaseA();

            string sqlQuery = " select ";
            sqlQuery += " ma as Ma, hoten as 'Ho ten', ngaysinh as 'Ngay sinh' , quequan as 'Que quan', ";
            sqlQuery += " gioitinh as 'Gioi tinh ', dantoc as 'Dan toc',  sodienthoai as 'So dien thoai', ";
            sqlQuery += " taikhoan as 'Tai khoan' , chucvuma as 'Chuc vu', luongcoban as Luong, ";
            sqlQuery += " phongbanma as 'Phong ban',  trinhdohocvanma as 'Hoc van' ";
            sqlQuery += " from nhanvien";

            return dbA.Select(sqlQuery, false);
        }

        private void frmmain_Activated(object sender, EventArgs e)
        {
            dgbNS.DataSource = GetData();
        }
    }
}
