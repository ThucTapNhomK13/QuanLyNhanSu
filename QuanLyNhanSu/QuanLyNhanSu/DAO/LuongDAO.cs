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
    public class LuongDAO
    {
        private static LuongDAO instance;

        public static LuongDAO Instance
        {
            get {
                if (instance == null)
                    instance = new LuongDAO();
                return LuongDAO.instance; }
            private set { LuongDAO.instance = value; }
        }

        private LuongDAO() { }

        public DataTable GetAll()
        {
            string sql = "select * from luong";
            return DataProvider.Instance.Select(sql, false);
        }
    }
}
