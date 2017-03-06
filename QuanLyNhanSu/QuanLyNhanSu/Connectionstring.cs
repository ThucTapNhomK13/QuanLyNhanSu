using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyNhanSu
{
    class connectionstring
    {
        /// <summary>
        /// Chuỗi kết nối của các thành viên trong nhóm
        /// </summary>
        public static string ConnectString = @"Data Source=MRKCUONG\MKCUONG;Initial Catalog=QuanLyNhanSu;Integrated Security=True";

        public static string hungcuongSQL = @"Data Source=MRKCUONG\MKCUONG;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
        public static string chuoiketnoi = @"Data Source=MYPC\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
    }
}
