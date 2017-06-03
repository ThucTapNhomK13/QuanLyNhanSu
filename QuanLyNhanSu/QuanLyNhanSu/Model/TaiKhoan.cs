using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.Model
{
    public class TaiKhoan
    {
        public string MaNV { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }

        public TaiKhoan() { }

        public TaiKhoan(DataRow row)
        {
            TenDangNhap = row["taikhoan"].ToString();
            MatKhau = row["matkhau"].ToString();
        }

        public TaiKhoan (string tendangnhap, string matkhau, string manv=null)
        {
            this.TenDangNhap = tendangnhap;
            this.MatKhau = matkhau;
            this.MaNV = manv;
        }
    }
}
