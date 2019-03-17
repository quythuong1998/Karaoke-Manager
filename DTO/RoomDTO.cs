using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoomDTO
    {
        private int idRoom;
        private string name;
        private int status;


        public string Name { get => name; set => name = value; }
        public int Status { get => status; set => status = value; }
        public int IdRoom { get => idRoom; set => idRoom = value; }
    }
}
