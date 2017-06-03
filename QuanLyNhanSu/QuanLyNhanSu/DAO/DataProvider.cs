using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyNhanSu
{
    public class DataProvider
    {
        //private SqlConnection con = null;

        private static DataProvider instance;

        public static DataProvider Instance
        {
            get 
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance; 
            }
            private set { instance = value; }
        }

        private DataProvider() { }


        /// <summary>
        /// Thực hiện truy vấn như hiển thị, tìm kiếm ... 
        /// </summary>
        /// <param name="sql">Lệnh sql hoặc Thủ tục</param>
        /// <param name="isProcedure">True - proc , False - query</param>
        /// <param name="parameters">Danh sách tham số vào</param>
        /// <returns></returns>
        public DataTable Select(string sqlQuery, bool isProc, Dictionary<string, object> parameters = null)
        {
            string ConnectString = connectionstring.ConnectString;
            using (SqlConnection sqlCon = new SqlConnection(ConnectString))
            {
                sqlCon.Open();
                using (SqlCommand sqlCmd = new SqlCommand(sqlQuery, sqlCon))
                {
                    if (isProc)
                        sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    else
                        sqlCmd.CommandType = System.Data.CommandType.Text;
                    if (parameters != null)
                        foreach (KeyValuePair<string, object> para in parameters)
                            sqlCmd.Parameters.Add(new SqlParameter(para.Key, para.Value));

                    using (SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sqlDa.Fill(dt);
                            return dt;
                        }
                    }

                }
            }
        }

        /// <summary>
        /// Thêm , Sửa , Xóa
        /// </summary>
        /// <param name="sql">Câu lệnh truy vấn hoặc thủ tục</param>
        /// <param name="parameters">Danh sách tham số</param>
        /// <param name="isProcedure">True - thủ tục  False - Câu lệnh truy vấn</param>
        /// <returns></returns>
        public bool InsertUpdateDelete(string sql, Dictionary<string, object> parameters, bool isProcedure)
        {

            string ConnectString = connectionstring.ConnectString;
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

                    if (sqlCmd.ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
            }

        }

        
    }
}
