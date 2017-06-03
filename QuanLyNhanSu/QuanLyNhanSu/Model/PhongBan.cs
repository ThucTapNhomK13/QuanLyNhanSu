using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Model
{
    public class PhongBan
    {
        public string Ma { get; set; }
        public string TenPhongBan { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }

        public PhongBan() { }
        public PhongBan (DataRow row)
        {
            Ma = row["ma"].ToString();
            TenPhongBan = row["tenphongban"].ToString();
            DiaChi = row["diachi"].ToString();
            SoDienThoai = row["sodienthoai"].ToString();
        }
    }
}
