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
    public class NhanSuDAO
    {
        private static NhanSuDAO instance;

        public static NhanSuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanSuDAO();
                return NhanSuDAO.instance;
            }
            private set { NhanSuDAO.instance = value; }
        }

        private NhanSuDAO() { }

        public DataTable GetAll()
        {
            string sql = "select * from nhanvien";
            return DataProvider.Instance.Select(sql, false);
        }

        public DataTable GetBySearch(string search)
        {
            string sql = "select * from nhanvien ";
            sql += "where quequan like '%'+ @tukhoa +'%' ";
            sql += "union ";

            sql += "select * from nhanvien ";
            sql += "where hoten like '%'+ @tukhoa +'%' ";
            sql += "union ";

            sql += "select * from nhanvien ";
            sql += "where gioitinh like '%'+ @tukhoa +'%' ";
            sql += "union ";

            sql += "select * from nhanvien ";
            sql += "where sodienthoai like '%'+ @tukhoa +'%' ";
            sql += "union ";

            sql += "select * from nhanvien ";
            sql += "where dantoc like '%'+ @tukhoa +'%' ";
            sql += "union ";

            sql += "select * from nhanvien ";
            sql += "where taikhoan like '%'+ @tukhoa +'%' ";
            sql += "union ";

            sql += "select * from nhanvien ";
            sql += "where phongbanma like '%'+ @tukhoa +'%' ";
            sql += "union ";

            sql += "select * from nhanvien ";
            sql += "where trinhdohocvanma like '%'+ @tukhoa +'%' ";
            sql += "union ";

            sql += "select * from nhanvien ";
            sql += "where ma like '%'+ @tukhoa +'%' ";

            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@tukhoa", search);

            return DataProvider.Instance.Select(sql, false, para);
        }

        public bool Insert(NhanSu ns)
        {
            string sql = "insert into nhanvien ";
            sql += " (ma, hoten, ngaysinh, quequan, gioitinh, dantoc, sodienthoai, taikhoan, luongcoban, chucvuma, phongbanma, trinhdohocvanma) ";
            sql += " values ";
            sql += " ma=@ma, hoten=@hoten, ngaysinh=@ngaysinh, quequan = @quequan, gioitinh=@gioitinh, dantoc=@dantoc, sodienthoai=@sodienthoai, taikhoan=@taikhoan, luongcoban=@luong, chucvuma=@chucvu, phongban=@phonban, trinhdohocvan=@hocvan";

            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@ma", ns.Ma);
            para.Add("@hoten", ns.HoTen);
            para.Add("@ngaysinh", ns.NgaySinh);
            para.Add("@quequan", ns.QueQuan);
            para.Add("@gioitinh", ns.GioiTinh);
            para.Add("@dantoc", ns.DanToc);
            para.Add("@sodienthoai", ns.SoDienThoai);
            para.Add("@taikhoan", ns.TaiKhoan);
            para.Add("@luong", ns.LuongConBan);
            para.Add("@chucvu", ns.ChuVuMa);
            para.Add("@phongban", ns.PhongBanMa);
            para.Add("@hocvan", ns.HocVanMa);

            return DataProvider.Instance.InsertUpdateDelete(sql, para, false);
        }

        public bool Update (NhanSu ns)
        {
            string sql = "update nhanvien ";
            sql += " set ";
            sql += " hoten=@hoten, ngaysinh=@ngaysinh, quequan = @quequan, gioitinh=@gioitinh, dantoc=@dantoc, sodienthoai=@sodienthoai, taikhoan=@taikhoan, luongcoban=@luong, chucvuma=@chucvu, phongban=@phonban, trinhdohocvan=@hocvan ";
            sql += " where ma = @ma ";

            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@ma", ns.Ma);
            para.Add("@hoten", ns.HoTen);
            para.Add("@ngaysinh", ns.NgaySinh);
            para.Add("@quequan", ns.QueQuan);
            para.Add("@gioitinh", ns.GioiTinh);
            para.Add("@dantoc", ns.DanToc);
            para.Add("@sodienthoai", ns.SoDienThoai);
            para.Add("@taikhoan", ns.TaiKhoan);
            para.Add("@luong", ns.LuongConBan);
            para.Add("@chucvu", ns.ChuVuMa);
            para.Add("@phongban", ns.PhongBanMa);
            para.Add("@hocvan", ns.HocVanMa);

            return DataProvider.Instance.InsertUpdateDelete(sql, para, false);
        }

        public bool Delete (string ma)
        {
            string sql = "delete nhanvien ";
            sql += " where ma = @ma ";

            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@ma", ma);
            
            return DataProvider.Instance.InsertUpdateDelete(sql, para, false);
        }
    }
}
