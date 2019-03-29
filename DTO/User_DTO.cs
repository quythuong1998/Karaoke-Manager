using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User_DTO
    {
        private string id;
        private string username;
        private string password;
        private string nameUser;
        private int permission;

        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string NameUser { get => nameUser; set => nameUser = value; }
        public int Permission { get => permission; set => permission = value; }
    }



}
