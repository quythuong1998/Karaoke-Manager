using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User_DTO
    {
        private int id;
        private string username;
        private string password;
        private string nameUser;
        private int permission;
        private string namePermission;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string NameUser { get => nameUser; set => nameUser = value; }
        public int Permission { get => permission; set => permission = value; }
        public string NamePermission { get => namePermission; set => namePermission = value; }
    }



}
