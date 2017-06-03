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
    public class HocVanDAO
    {
        private static HocVanDAO instance;

        public static HocVanDAO Instance
        {
            get 
            {
                if (instance == null)
                    instance = new HocVanDAO();
                return HocVanDAO.instance; 
            }
            private set { HocVanDAO.instance = value; }
        }

        private HocVanDAO() { }

        public DataTable GetAll ()
        {
            string sql = "select * from trinhdohocvan";
            return DataProvider.Instance.Select(sql, false);
        }

        public DataTable GetById (string id)
        {
            string sql = "select * from trinhdohocvan where ma like @ma";
            Dictionary<string, object> para = new Dictionary<string,object>();
            para.Add("@ma", id);

            return DataProvider.Instance.Select(sql, false, para);
        }
    }
}
