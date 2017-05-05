﻿using System;
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
            using (frmdangnhap dn = new frmdangnhap())
            {
                dn.ShowDialog();
                if (dn.dangnhapthanhcong)
                {
                    this.Close();
                }
            }                
        }

        private void itemtimkiem_Click(object sender, EventArgs e)
        {
            frmTimKiem tk = new frmTimKiem();
            tk.ShowDialog();
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
            dgvNV.DataSource = GetData();
            dgvNV.Visible = true;
            btnsua.Visible = true;
            btnxoa.Visible = false;
        }

        private void itemxoanhansu_Click(object sender, EventArgs e)
        {
            dgvNV.DataSource = GetData();
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

        private DataTable GetData ()
        {
            DataProvider dbA = new DataProvider();

            string sqlQuery = " select ";
            sqlQuery += " ma , hoten , ngaysinh, gioitinh , ";
            sqlQuery += " quequan , dantoc ,  sodienthoai , ";
            sqlQuery += " taikhoan , chucvuma as chucvu , luongcoban as luong, ";
            sqlQuery += " phongbanma as phongban ,  trinhdohocvanma as hocvan";
            sqlQuery += " from nhanvien";

            return dbA.Select(sqlQuery, false, null);
        }

        private void frmmain_Activated(object sender, EventArgs e)
        {
            dgvNV.DataSource = GetData();
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
                // 
                string id = dgvNV[0, selectIndex].Value.ToString();

                DataProvider dbA = new DataProvider();

                string sqlQuery = " Delete nhanvien ";
                sqlQuery += " where ma=@ma ";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@ma", id);

                if (dbA.InsertUpdateDelete(sqlQuery, parameters, false))
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
