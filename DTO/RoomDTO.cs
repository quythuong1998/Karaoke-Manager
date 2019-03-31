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
        private float price;
        private int kind_Of_Room;
        

        public string Name { get => name; set => name = value; }
        public int Status { get => status; set => status = value; }
        public int IdRoom { get => idRoom; set => idRoom = value; }
        public int Kind_Of_Room { get => kind_Of_Room; set => kind_Of_Room = value; }
        public float Price { get => price; set => price = value; }
    }
}
