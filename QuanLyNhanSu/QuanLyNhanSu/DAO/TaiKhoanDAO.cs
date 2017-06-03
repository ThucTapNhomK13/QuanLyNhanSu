using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using QuanLyNhanSu.Model;

namespace QuanLyNhanSu.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get 
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return TaiKhoanDAO.instance; 
            }
            private set { instance = value; }
        }

        private TaiKhoanDAO() { }

        public int GetByAccount (TaiKhoan tk)
        {
            string sql = "select taikhoan, matkhau from nhanvien where taikhoan=@taikhoan and matkhau=@matkhau";
            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@taikhoan", tk.TenDangNhap);
            para.Add("@matkhau", tk.MatKhau);

            DataTable dt = DataProvider.Instance.Select(sql, false, para);
            
            List<TaiKhoan> lsAcc = new List<TaiKhoan>();
            foreach(DataRow row in dt.Rows)
            {
                lsAcc.Add(new TaiKhoan(row));
            }
            return lsAcc.Count;
        }
    }
}
