using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QuanLyNhanSu.Model;
using QuanLyNhanSu.DAO;

namespace QuanLyNhanSu.BUS
{
    public class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;

        public static TaiKhoanBUS Instance
        {
            get 
            {
                if (instance == null)
                    instance = new TaiKhoanBUS();
                return TaiKhoanBUS.instance; 
            }
            private set { TaiKhoanBUS.instance = value; }
        }

        private TaiKhoanBUS() { }

        public bool DangNhap (TaiKhoan tk)
        {
            if (TaiKhoanDAO.Instance.GetByAccount(tk) > 0)
                return true;

            return false;
        }
    }
}
