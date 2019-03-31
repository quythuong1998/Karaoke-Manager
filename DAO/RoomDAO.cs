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
                room.Kind_Of_Room = int.Parse(dt.Rows[i]["kind_Of_Room"].ToString());
                room.Price = float.Parse(dt.Rows[i]["price"].ToString());
                listRoom.Add(room);
            }
            return listRoom;
        }

        public static bool AddRoom(RoomDTO r)
        {
            string query = string.Format(@"insert into ROOM values(N'{0}',N'{1}',N'{2}',N'{3}')", r.Name, r.Status, r.Kind_Of_Room, r.Price);
            con = DataProvider.OpenConnection();
            bool kq = DataProvider.ExcuteNonQuery(query, con);
            //DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool EditRoom(RoomDTO r)
        {
            string query = string.Format(@"update ROOM set name=N'{0}',status={1},kind_Of_Room={2},price={3} where id_Room={4}", r.Name, r.Status, r.Kind_Of_Room, r.Price, r.IdRoom);
            con = DataProvider.OpenConnection();
            bool kq = DataProvider.ExcuteNonQuery(query, con);
            //DataProvider.DongKetNoi(con);
            return kq;
        }

        // Xóa nhân viên
        public static bool DeleteRoom(int id)
        {
            string query = string.Format(@"delete from ROOM where id_Room= " + id);
            con = DataProvider.OpenConnection();
            bool kq = DataProvider.ExcuteNonQuery(query, con);
            //DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
