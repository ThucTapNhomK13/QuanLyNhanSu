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
            frmSuaNhanSu frmsua = new frmSuaNhanSu();
            frmsua.ShowDialog();
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
    }
}
