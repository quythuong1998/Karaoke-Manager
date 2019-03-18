using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class RoomDAO
    {
        static SqlConnection con;
        public static List<DTO.RoomDTO> GetRooms()
        {
            string stringquery = "select* from ROOM";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.ExcuteQuery(stringquery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<RoomDTO> listRoom = new List<RoomDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                RoomDTO room = new RoomDTO();
                room.IdRoom = int.Parse(dt.Rows[i]["id_Room"].ToString());
                room.Name = dt.Rows[i]["name"].ToString();
                room.Status = int.Parse(dt.Rows[i]["status"].ToString());
                listRoom.Add(room);
            }
            return listRoom;
        }
    }
}
