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
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        #region Ham

        private void LoadNhanSu ()
        {
            dgvNV.DataSource = NhanSuBUS.Instance.GetAll();
        }

        #endregion

        private void itemtimkiem_Click(object sender, EventArgs e)
        {
            using (frmTimKiem tk = new frmTimKiem())
            {
                tk.ShowDialog();
            }
            
        }

        private void itemthemnhansumoi_Click(object sender, EventArgs e)
        {
            using (frmThemNhanSu frmthem = new frmThemNhanSu())
            {
                frmthem.ShowDialog();
            }
        }

        private void itemsuanhansu_Click(object sender, EventArgs e)
        {
            LoadNhanSu();
            dgvNV.Visible = true;
            btnsua.Visible = true;
            btnxoa.Visible = false;
        }

        private void itemxoanhansu_Click(object sender, EventArgs e)
        {
            LoadNhanSu();
            dgvNV.Visible = true;
            btnsua.Visible = false;
            btnxoa.Visible = true;
        }

        private void itemhuongdansudung_Click(object sender, EventArgs e)
        {
            frmHuongDanSuDung frmhd = new frmHuongDanSuDung();
            frmhd.ShowDialog();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            
        }

        private void frmmain_Activated(object sender, EventArgs e)
        {
            //dgvNV.DataSource = GetData();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count > 0)
            {
                int selectIndex = dgvNV.SelectedRows[0].Index;
                // Lay ma trong datagridview o cot dau tien 
                string id = dgvNV[0, selectIndex].Value.ToString();
                frmSuaNhanSu frmsua = new frmSuaNhanSu(id);
                frmsua.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count > 0)
            {
                int selectIndex = dgvNV.SelectedRows[0].Index;
                string id = dgvNV[0, selectIndex].Value.ToString();

                if (NhanSuBUS.Instance.Delete(id))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhanSu();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
                MessageBox.Show("Bạn chưa chọn nhân viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void itemDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
