using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.Model
{
    public class ChucVu
    {
        public string Ma { get; set; }
        public string TenChucVu { get; set; }

        public ChucVu() { }
        public ChucVu (DataRow row)
        {
            Ma = row["ma"].ToString();
            TenChucVu = row["tenchucvu"].ToString();
        }

    }
}
