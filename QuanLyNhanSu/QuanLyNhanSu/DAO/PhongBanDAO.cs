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
    public class PhongBanDAO
    {
        private static PhongBanDAO instance;

        public static PhongBanDAO Instance
        {
            get 
            {
                if (instance == null)
                    instance = new PhongBanDAO();
                return PhongBanDAO.instance; 
            }
            private set { PhongBanDAO.instance = value; }
        }

        private PhongBanDAO() { }

        public DataTable GetAll ()
        {
            string slq = "select * from phongban";
            return DataProvider.Instance.Select(slq, false);
        }

        public DataTable GetById (string id)
        {
            string sql = "select * from phongban where ma like @ma";
            Dictionary<string, object> para = new Dictionary<string,object>();
            para.Add("@ma", id);

            return DataProvider.Instance.Select(sql, false, para); 
        }
    }
}
