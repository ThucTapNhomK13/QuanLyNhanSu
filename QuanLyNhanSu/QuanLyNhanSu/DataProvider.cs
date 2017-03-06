using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyNhanSu
{
    class DataProvider
    {
        private SqlConnection con = null;

        /// <summary>
        /// Thực hiện truy vấn như hiển thị, tìm kiếm ... 
        /// </summary>
        /// <param name="sql">Lệnh sql hoặc Thủ tục</param>
        /// <param name="isProcedure">True - proc , False - query</param>
        /// <param name="parameters">Danh sách tham số vào</param>
        /// <returns></returns>
        public DataTable Select(string sql, bool isProcedure, Dictionary<string, object> parameters = null)
        {
            string ConnectString = connectionstring.ConnectString;
            using (SqlConnection sqlCon = new SqlConnection(ConnectString))
            {
                sqlCon.Open();
                using (SqlCommand sqlCmd = new SqlCommand(sql, sqlCon))
                {
                    if (isProcedure)
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

        // Mở kết nối để thực hiện thao tác
        public int open()
        {
            con = new SqlConnection(connectionstring.ConnectString);
            try
            {
                con.Open();
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
                return -1;
            }
            return 0;
        }

        // Kiểm tra kết nối

        public int isopen()
        {
            if(con == null)
            {
                return -1;
            }
            if(con.State == ConnectionState.Closed)
            {
                return -2;
            }
            return 0;
        }

        // Đóng và giải phóng kết nối

        public void close()
        {
            if(isopen() == 0)
            {
                con.Close();
                con = null;
            }
        }

        // Thực hiện câu lệnh select bằng store
        public int ExecuteNonQuerry(string storename, SqlParameter[] pa = null)
        {
            int ret = 0;
            if(open()==0)
            {
                open();
            }
            SqlCommand cm = new SqlCommand();
            cm.CommandText = storename;
            cm.Connection = con;
            cm.CommandType = CommandType.StoredProcedure;
            if (pa != null)
                cm.Parameters.AddRange(pa);
            try
            {
                ret = cm.ExecuteNonQuery();
            }
            catch(Exception)
            {
                ret = -1;
            }
            close();
            return ret;
        }

        // Lấy dữ liệu vào datatable
        public DataTable GetData(string querry, SqlParameter[] pa = null)
        {
            DataTable dt = new DataTable();
            SqlCommand cm = new SqlCommand();
            cm.CommandText = querry;
            cm.Connection = con;
            //int ret = 0;
            if(open() == 0)
            {
                open();
            }
            if(pa!=null)
            {
                cm.Parameters.AddRange(pa);
            }

            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            close();
            return dt;
        }

        // Đăng nhập
        public int DangNhap(string querry, SqlParameter[] pa = null)
        {
            int ret = 0;
            SqlCommand cm = new SqlCommand();
            cm.CommandText = querry;
            cm.Connection = con;
            if(open() == 0)
            {
                open();
            }
            if(pa != null)
            {
                cm.Parameters.AddRange(pa);
            }
            try
            {
                ret = (Int32)cm.ExecuteScalar();
            }
            catch(Exception)
            {
                return -1;
            }
            close();
            return ret;
        }
    }
}
