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

namespace QuanLyNhanSu
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = NhanSuBUS.Instance.GetBySearch(txtTimKiem.Text.Trim());

        }

    }
}
