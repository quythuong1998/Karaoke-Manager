using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAO
{
    public class User_DAO
    {
        static SqlConnection con;
        public static List<DTO.User_DTO> GetAllUsers()
        {
            string stringquery = "select u.id_User, u.username, u.password, u.nameUser, u.id_Permission, p.name_Permission from USER_ACCOUNT AS u, PERMISSION as p where u.id_Permission = p.id_Permission";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.ExcuteQuery(stringquery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<User_DTO> listUsers = new List<User_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                User_DTO u = new User_DTO();
                u.Id = int.Parse(dt.Rows[i]["id_User"].ToString());
                u.Username = dt.Rows[i]["username"].ToString();
                u.Password = dt.Rows[i]["password"].ToString();
                u.NameUser = dt.Rows[i]["nameUser"].ToString();
                u.Permission = int.Parse(dt.Rows[i]["id_Permission"].ToString());
                u.NamePermission = dt.Rows[i]["name_Permission"].ToString();
                listUsers.Add(u);
            }
            return listUsers;
        }

        public static List<DTO.User_DTO> GetUser(string userName, string passWord)
        {
            string stringquery = "SELECT * FROM USER_ACCOUNT WHERE username = '" + userName + "' AND password = '" + passWord + "' ";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.ExcuteQuery(stringquery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<User_DTO> User = new List<User_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                User_DTO u = new User_DTO();
                u.Id = int.Parse(dt.Rows[i]["id_User"].ToString());
                u.Username = dt.Rows[i]["username"].ToString();
                u.Password = dt.Rows[i]["password"].ToString();
                u.NameUser = dt.Rows[i]["nameUser"].ToString();
                u.Permission = int.Parse(dt.Rows[i]["id_Permission"].ToString());
                User.Add(u);
            }
            return User;
        }


        public static bool Login(string userName, string passWord)
        {   
            string stringquery = "SELECT * FROM USER_ACCOUNT WHERE username = '" + userName + "' AND password = '" + passWord + "' ";
            con = DataProvider.OpenConnection();
            DataTable result = DataProvider.ExcuteQuery(stringquery, con); //dung nonquery tu nhien bi loi~ :v
            return result.Rows.Count > 0;
        }

        public static bool AddUser(User_DTO u)
        {
            string query = string.Format(@"insert into USER_ACCOUNT values(N'{0}',N'{1}',N'{2}',N'{3}')", u.Username, "202cb962ac59075b964b07152d234b70", u.NameUser, u.Permission);
            con = DataProvider.OpenConnection();
            bool kq = DataProvider.ExcuteNonQuery(query, con);
            //DataProvider.DongKetNoi(con);
            return kq;
        }


        public static bool DeleteUser(User_DTO u)
        {
            string query = string.Format(@"delete from USER_ACCOUNT where id_User= " + u.Id);
            con = DataProvider.OpenConnection();
            bool kq = DataProvider.ExcuteNonQuery(query, con);
            //DataProvider.DongKetNoi(con);
            return kq;
        }

        
        public static bool ChangePassword(string passWord, int id)
        {
            string query = string.Format(@"update USER_ACCOUNT set password = '" + passWord + "' where id_User =" + id);
            con = DataProvider.OpenConnection();
            bool kq = DataProvider.ExcuteNonQuery(query, con);
            //DataProvider.DongKetNoi(con);
            return kq;
        } 
    }
}
