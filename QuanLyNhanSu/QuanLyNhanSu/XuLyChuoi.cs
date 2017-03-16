using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;


namespace QuanLyNhanSu
{
    class XuLyChuoi
    {

        /// <summary>
        /// Các chuỗi kiểm tra dữ liệu đầu vào
        /// </summary>
        private static string hoten = @"^([\D\w]+\s)+[\D\w]+$";
        private static string sodienthoai = @"(\\+84|0)\d{9,10}";
        private static string taikhoan = @"^\w+$";
        private static string ma = @"\d+";


        /// <summary>
        /// Đảo ngược một chuỗi
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray(); // chuỗi thành mảng ký tự
            Array.Reverse(arr); // đảo ngược mảng
            return new string(arr); // trả về chuỗi mới sau khi đảo mảng
        }

<<<<<<< HEAD
        /// <summary>
        /// Kiểm tra 'ma' 
        /// </summary>
        /// <param name="dulieu">Mã</param>
        /// <returns></returns>
        public static bool KiemTraMa (string dulieu=null)
        {
            if (!string.IsNullOrEmpty(dulieu) && Regex.IsMatch(dulieu, ma))
                return true;
            return false;
        }

        /// <summary>
        /// Kiểm tra 'hoten'
        /// </summary>
        /// <param name="Hoten">Họ tên</param>
        /// <returns></returns>
        public static bool KiemTraHoTen (string Hoten=null)
        {
            if (!string.IsNullOrEmpty(Hoten) && Regex.IsMatch(Hoten, hoten))
                return true;
            return false;
        }

        /// <summary>
        /// Kiểm tra 'sodienthoai'
        /// </summary>
        /// <param name="SDT">Số điện thoại</param>
        /// <returns></returns>
        public static bool KiemTraSDT (string SDT=null)
        {
            if (!string.IsNullOrWhiteSpace(SDT) && Regex.IsMatch(SDT, sodienthoai))
                return true;
            return false;

        }

        /// <summary>
        /// Kiểm tra 'taikhoan'
        /// </summary>
        /// <param name="TaiKhoan">Tài khoản</param>
        /// <returns></returns>
        public static bool KiemTraTaiKhoan (string TaiKhoan=null)
        {
            if (!string.IsNullOrWhiteSpace(TaiKhoan) && Regex.IsMatch(TaiKhoan, taikhoan))
                return true;
            return false;
        }

        /// <summary>
        /// Viết hoa chữ cái đầu
        /// </summary>
        /// <param name="s">Chuỗi </param>
        /// <returns></returns>
        public static string VietHoaChuCaiDau(string s)
        {
            return System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
        }

        /// <summary>
        /// Viết thường
        /// </summary>
        /// <param name="text">Chuỗi </param>
        /// <returns></returns>
        public static string VietThuong (string text)
        {
            return text.ToLower();
        }

        /// <summary>
        /// Viết hoa toàn bộ
        /// </summary>
        /// <param name="text">Chuỗi</param>
        /// <returns></returns>
        public static string VietHoa (string text)
        {
            return text.ToUpper();
=======
        public static string chuanhoa(string s)
        {
            s = s.ToLower();
            s = s.Trim();
            while (s.Contains("  "))
            {
                s = s.Replace("  ", " ");
            }
            string[] str = s.Split(' ');
            string strResult = "";
            foreach (string item in str)
            {
                strResult += item.Substring(0, 1).ToUpper() + item.Substring(1) + " ";
            }
            return strResult;
>>>>>>> origin/master
        }
    }
}
