using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Model
{
    public class Luong
    {
        public float LuongCoBan { get; set; }
        public float HeSoLuong { get; set; }
        public float HeSoPhuCap { get; set;}

        public Luong() { }
        public Luong(DataRow row)
        {
            LuongCoBan = float.Parse(row["luongcoban"].ToString());
            HeSoLuong = float.Parse(row["hesoluong"].ToString());
            HeSoPhuCap = float.Parse(row["hesophucap"].ToString());
        }

    }
}
