using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;



namespace QuanLyNhanSu
{
    class DatabaseA
    {
        public bool InsertUpdateDelete(string sql, Dictionary<string, object> parameters, bool isProcedure)
        {
            try
            {
                string ConnectString = connectionstring.hungcuongSQL;
                using (SqlConnection sqlCon = new SqlConnection(ConnectString))
                {
                    sqlCon.Open();
                    //MessageBox.Show("Ket noi thanh cong");
                    using (SqlCommand sqlCmd = new SqlCommand(sql, sqlCon))
                    {
                        if (isProcedure)
                            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                        else
                            sqlCmd.CommandType = System.Data.CommandType.Text;

                        foreach (KeyValuePair<string, object> parameter in parameters)
                            sqlCmd.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value));

                        sqlCmd.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
            
        }
    }
}
