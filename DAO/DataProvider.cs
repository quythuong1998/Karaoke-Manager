using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DataProvider
    {
        public static SqlConnection OpenConnection()
        {
            string s = "Data Source=QUYTHUONG9E13\\SQLEXPRESS;Initial Catalog=KARAOKE_MANAGER;Integrated Security=True";
            SqlConnection Connect = new SqlConnection(s);
            Connect.Open();
            return Connect;
        }
            
        // Thực hiện truy vấn trả về bảng dữ liệu

        public static DataTable ExcuteQuery(string stringQuery, SqlConnection Connect)
        {
            SqlDataAdapter da = new SqlDataAdapter(stringQuery, Connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Thực hiện truy vấn không trả về dữ liệu
        public static bool ExcuteNonQuery(string stringQuery, SqlConnection Connect)
        {

            try
            {
                SqlCommand cm = new SqlCommand(stringQuery, Connect);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static object ExecuteScalar(string stringQuery, SqlConnection Connect)
        {
            SqlCommand cm = new SqlCommand(stringQuery, Connect);    
            return cm.ExecuteScalar();
        }
    }
}
