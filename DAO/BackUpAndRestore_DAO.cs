using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BackUpAndRestore_DAO
    {
        static SqlConnection con;
        public static bool Backup(string path)
        {
            string nameOfFile = @"\KaraokeManager (" + DateTime.Now.Day.ToString() + "_" +
            DateTime.Now.Month.ToString() + "_" +
            DateTime.Now.Year.ToString() + "_" +
            DateTime.Now.Hour.ToString() + "_" +
            DateTime.Now.Minute.ToString() + ").bak";
            string query = "BACKUP DATABASE KARAOKE_MANAGER TO DISK = N'" + path +
            nameOfFile + "'";
            con = DataProvider.OpenConnection();
            bool kq = DataProvider.ExcuteNonQuery(query, con);
            return kq;
        }
        public static bool Restore(string path)
        {
            string query = "Use master Restore Database KARAOKE_MANAGER from disk = N'" + path+"'";
            con = DataProvider.OpenConnection();
            bool kq = DataProvider.ExcuteNonQuery(query, con);
            return kq;
        }
    }


}
