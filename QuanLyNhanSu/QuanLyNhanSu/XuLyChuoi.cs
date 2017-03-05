using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    class XuLyChuoi
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray(); // chuỗi thành mảng ký tự
            Array.Reverse(arr); // đảo ngược mảng
            return new string(arr); // trả về chuỗi mới sau khi đảo mảng
        }
    }
}
