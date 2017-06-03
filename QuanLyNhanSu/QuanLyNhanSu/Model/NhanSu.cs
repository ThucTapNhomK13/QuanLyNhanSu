using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.Model
{
    public class NhanSu
    {
        public string Ma { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string GioiTinh { get; set; }
        public string DanToc { get; set; }
        public string SoDienThoai { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string ChuVuMa { get; set; }
        public float LuongConBan { get; set; }
        public string PhongBanMa { get; set; }
        public string HocVanMa { get; set; }

        public NhanSu() { }
        
        public NhanSu (DataRow row)
        {
            Ma = row["ma"].ToString();
            HoTen = row["hoten"].ToString();
            NgaySinh = DateTime.Parse(row["ngaysinh"].ToString());
            QueQuan = row["quequan"].ToString();
            GioiTinh = row["gioitinh"].ToString();
            DanToc = row["dantoc"].ToString();
            SoDienThoai = row["sodienthoai"].ToString();
            
            TaiKhoan = row["taikhoan"].ToString();
            MatKhau = row["matkhau"].ToString();
            ChuVuMa = row["chucvuma"].ToString();
            LuongConBan = float.Parse(row["luongcoban"].ToString());
            PhongBanMa = row["phongbanma"].ToString();
            HocVanMa = row["trinhdohocvanma"].ToString();
        }
    }
}
