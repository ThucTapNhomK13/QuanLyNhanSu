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
    public class PhongBanBUS
    {
        private static PhongBanBUS instance;

        public static PhongBanBUS Instance
        {
            get {
                if (instance == null)
                    instance = new PhongBanBUS();
                return PhongBanBUS.instance; }
            private set { PhongBanBUS.instance = value; }
        }

        private PhongBanBUS() { }

        private List<PhongBan> MakeToList (DataTable dt)
        {
            List<PhongBan> lsPB = new List<PhongBan>();
            foreach (DataRow row in dt.Rows)
                lsPB.Add(new PhongBan(row));
            return lsPB;
        }

        public List<PhongBan> GetAll ()
        {
            return MakeToList(PhongBanDAO.Instance.GetAll());
        }

        public string GetById (string ma)
        {
            List<PhongBan> ls = MakeToList(PhongBanDAO.Instance.GetById(ma));
            return ls[0].TenPhongBan;
        }
    }
}
