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
    public class HocVanBUS
    {
        private static HocVanBUS instance;

        public static HocVanBUS Instance
        {
            get {
                if (instance == null)
                    instance = new HocVanBUS();
                return HocVanBUS.instance; }
            private set { HocVanBUS.instance = value; }
        }

        private HocVanBUS(){        }

        private List<HocVan> MakeToList (DataTable dt)
        {
            List<HocVan> lsHocVan = new List<HocVan>();
            foreach(DataRow row in dt.Rows)
            {
                lsHocVan.Add(new HocVan(row));
            }
            return lsHocVan;
        }

        public List<HocVan> GetAll ()
        {
            return MakeToList(HocVanDAO.Instance.GetAll());
        }

        public string GetByName (string ma)
        {
            List<HocVan> ls = MakeToList(HocVanDAO.Instance.GetById(ma));
            return ls[0].TrinhDoHocVan;
        }
    }
}
