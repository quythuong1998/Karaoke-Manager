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
            string stringquery = "select* from USER_ACCOUNT";
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
                u.Id = dt.Rows[i]["id_User"].ToString();
                u.Username = dt.Rows[i]["username"].ToString();
                u.Password = dt.Rows[i]["password"].ToString();
                u.NameUser = dt.Rows[i]["nameUser"].ToString();
                u.Permission = int.Parse(dt.Rows[i]["nameUser"].ToString());
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
                u.Id = dt.Rows[i]["id_User"].ToString();
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


    }
}
