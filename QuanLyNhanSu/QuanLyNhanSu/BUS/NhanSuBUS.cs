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
    public class NhanSuBUS
    {
        private static NhanSuBUS instance;

        public static NhanSuBUS Instance
        {
            get 
            {
                if (instance == null)
                    instance = new NhanSuBUS();
                return NhanSuBUS.instance; 
            }
            private set { instance = value; }
        }

        private NhanSuBUS() { }

        private List<NhanSu> MakeToList (DataTable dt)
        {
            List<NhanSu> ls = new List<NhanSu>();
            foreach(DataRow item in dt.Rows)
            {
                ls.Add(new NhanSu(item));
            }
            return ls;
        }

        public List<NhanSu> GetAll ()
        {
            return MakeToList(NhanSuDAO.Instance.GetAll());
        }

        public List<NhanSu> GetBySearch (string search)
        {
            return MakeToList(NhanSuDAO.Instance.GetBySearch(search));
        }

        public bool Insert (NhanSu ns)
        {
            return NhanSuDAO.Instance.Insert(ns);
        }

        public bool Update (NhanSu ns)
        {
            return NhanSuDAO.Instance.Update(ns);
        }

        public bool Delete (string ma)
        {
            return NhanSuDAO.Instance.Delete(ma);
        }

        public bool CheckId (string ma)
        {
            List<NhanSu> ls = MakeToList(NhanSuDAO.Instance.GetById(ma));

            if (ls.Count == 0)
                return true;
            return false;

        }

        public NhanSu GetById (string ma)
        {
            List<NhanSu> ls = MakeToList(NhanSuDAO.Instance.GetById(ma));

            return ls[0];
        }
    }
}
