using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using QuanLyNhanSu.Model;
using QuanLyNhanSu.DAO;

namespace QuanLyNhanSu.BUS
{
    public class ChucVuBUS
    {
        private static ChucVuBUS instance;

        public static ChucVuBUS Instance
        {
            get 
            {
                if (instance == null)
                    instance = new ChucVuBUS();
                return ChucVuBUS.instance; 
            }
            private set { ChucVuBUS.instance = value; }
        }

        private ChucVuBUS() { }
        
        private List<ChucVu> MakeToList (DataTable dt)
        {
            List<ChucVu> lsCV = new List<ChucVu>();
            foreach(DataRow item in dt.Rows)
            {
                lsCV.Add(new ChucVu(item));
            }
            return lsCV;
        }

        public List<ChucVu> GetAll ()
        {
            return MakeToList(ChucVuDAO.Instance.GetAll());
        }

        public string GetByName (string ma)
        {
            List<ChucVu> ls = MakeToList(ChucVuDAO.Instance.GetById(ma));
            return ls[0].TenChucVu;
        }
    }
}
