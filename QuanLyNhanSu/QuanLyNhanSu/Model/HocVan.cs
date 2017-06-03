using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    public class HocVan
    {
        public string Ma { get; set; }
        public string TrinhDoHocVan { get; set; }
        public string ChuyenNganh { get; set; }

        public HocVan() { }

        public HocVan(DataRow row)
        {
            Ma = row["ma"].ToString();
            TrinhDoHocVan = row["tentrinhdohocvan"].ToString();
            ChuyenNganh = row["chuyennganh"].ToString();

        }
    }
}
