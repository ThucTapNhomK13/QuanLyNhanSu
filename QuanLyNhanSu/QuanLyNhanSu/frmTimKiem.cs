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
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // ma hoten ngaysinh quequan gioitinh dantoc sodienthoai taikhoan matkhau 
            // chucvuma luongcoban phongbanma trinhdohocvanma

            //dgvDanhSach.Rows.Clear();

            DataProvider dp = new DataProvider();

            string sqlQuery = " select ma, hoten, ngaysinh, quequan ";
            sqlQuery += " from nhanvien ";
            sqlQuery += " where ma like '%'+@ma+'%' ";
            sqlQuery += " union ";
            sqlQuery += " select ma, hoten, ngaysinh, quequan ";
            sqlQuery += " from nhanvien ";
            sqlQuery += " where hoten like '%'+@hoten+'%'";
            sqlQuery += " union ";
            sqlQuery += " select ma, hoten, ngaysinh, quequan ";
            sqlQuery += " from nhanvien ";
            sqlQuery += " where quequan like '%'+@quequan+'%' ";
            sqlQuery += " union ";
            sqlQuery += " select ma, hoten, ngaysinh, quequan ";
            sqlQuery += " from nhanvien ";
            sqlQuery += " where ngaysinh like '%'+@ngaysinh+'%'";

            

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ma", txtTimKiem.Text);
            parameters.Add("@hoten", txtTimKiem.Text);
            parameters.Add("@quequan", txtTimKiem.Text);
            parameters.Add("@ngaysinh", txtTimKiem.Text);


            dgvDanhSach.DataSource = dp.Select(sqlQuery, false, parameters);
               


            


         
        }
    }
}
