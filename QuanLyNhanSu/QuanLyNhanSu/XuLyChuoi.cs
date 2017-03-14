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
        }
    }
}
