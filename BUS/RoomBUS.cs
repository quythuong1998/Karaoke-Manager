using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class RoomBUS
    {

        public static List<RoomDTO> GetRooms()
        {
            return RoomDAO.GetRooms();
        }

        public static bool AddRoom(RoomDTO r)
        {
            return RoomDAO.AddRoom(r);
        }

        public static bool EditRoom(RoomDTO r)
        {
            return RoomDAO.EditRoom(r);
        }
        public static bool DeleteRoom(int id)
        {
            return RoomDAO.DeleteRoom(id);
        }
    }
}
