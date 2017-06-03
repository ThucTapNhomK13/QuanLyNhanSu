using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using QuanLyNhanSu.Model;
using QuanLyNhanSu.DAO;

namespace QuanLyNhanSu.BUS
{
    public class LuongBUS
    {
        private static LuongBUS instance;

        public static LuongBUS Instance
        {
            get {
                if (instance == null)
                    instance = new LuongBUS();
                return LuongBUS.instance; }
            private set { LuongBUS.instance = value; }
        }

        private LuongBUS() { }

        private List<Luong> MakeToList (DataTable dt)
        {
            List<Luong> lsLuong = new List<Luong>();
            foreach (DataRow item in dt.Rows)
            {
                lsLuong.Add(new Luong(item));
            }
            return lsLuong;
        }

        public List<Luong> GetAll ()
        {
            return MakeToList(LuongDAO.Instance.GetAll());
        }
    }
}
