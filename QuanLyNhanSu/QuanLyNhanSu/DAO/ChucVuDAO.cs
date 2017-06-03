using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.DAO
{
    public class ChucVuDAO
    {
        private static ChucVuDAO instance;
        public static ChucVuDAO Instance
        {
            get 
            {
                if (instance == null)
                    instance = new ChucVuDAO();
                return ChucVuDAO.instance; 
            }
            private set { ChucVuDAO.instance = value; }
        }
        private ChucVuDAO() { }

        public DataTable GetAll ()
        {
            string sql = "select * from chucvu ";
            return DataProvider.Instance.Select(sql, false);
        }
    }
}
