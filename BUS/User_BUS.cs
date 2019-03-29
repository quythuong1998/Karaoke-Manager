using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class User_BUS
    {
        public static List<DTO.User_DTO> GetAllUsers()
        {
            return DAO.User_DAO.GetAllUsers();
        }
        public static List<DTO.User_DTO> GetUser(string username, string password)
        {
            return DAO.User_DAO.GetUser(username, password);
        }

        public static bool Login(string username, string password)
        {
            return DAO.User_DAO.Login(username, password);
        }
        
    }
}
