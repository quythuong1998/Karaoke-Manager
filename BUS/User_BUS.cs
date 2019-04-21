using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            MD5 md5Hash = MD5.Create();
            string passowrd_MD5 = GetMd5Hash(md5Hash, password);
            return DAO.User_DAO.GetUser(username, passowrd_MD5);
        }

        public static bool Login(string username, string password)
        {
            //return DAO.User_DAO.Login(username, password);
            MD5 md5Hash = MD5.Create();
            string passowrd_MD5 = GetMd5Hash(md5Hash, password);
            return DAO.User_DAO.Login(username, passowrd_MD5);
        }

        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public static bool AddUser(DTO.User_DTO u)
        {
            return DAO.User_DAO.AddUser(u);
        }

        public static bool DeleteUser(DTO.User_DTO u)
        {
            return DAO.User_DAO.DeleteUser(u);
        }

        public static bool ChangePassword(string passWord, int id)
        {
            MD5 md5Hash = MD5.Create();
            string passowrd_MD5 = GetMd5Hash(md5Hash, passWord);
            return DAO.User_DAO.ChangePassword(passowrd_MD5, id);
        }

    }
}
