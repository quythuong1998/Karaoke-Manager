using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class menu_DAO
    {
        static SqlConnection con;
        public static List<DTO.Menu_DTO> GetAllMenu()
        {
            string stringquery = "select * from menu";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.ExcuteQuery(stringquery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO.Menu_DTO> listMenu = new List<DTO.Menu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO.Menu_DTO menu = new DTO.Menu_DTO();
                menu.Id = int.Parse(dt.Rows[i]["Id_nenu"].ToString());
                menu.Name = dt.Rows[i]["name"].ToString();
                menu.Price = float.Parse(dt.Rows[i]["unit_Price"].ToString());
                menu.Amout = int.Parse(dt.Rows[i]["amout"].ToString());
                menu.Kind = int.Parse(dt.Rows[i]["id_Kind"].ToString());
                listMenu.Add(menu);
            }

            return listMenu;
        }

        public static List<DTO.Menu_DTO> GetMenuByID(int id)
        {
            string stringquery = "select * from MENU where id_Kind = " + id;
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.ExcuteQuery(stringquery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO.Menu_DTO> listMenu = new List<DTO.Menu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO.Menu_DTO menu = new DTO.Menu_DTO();
                menu.Id = int.Parse(dt.Rows[i]["Id_nenu"].ToString());
                menu.Name = dt.Rows[i]["name"].ToString();
                menu.Price = float.Parse(dt.Rows[i]["unit_Price"].ToString());
                menu.Amout = int.Parse(dt.Rows[i]["amout"].ToString());
                menu.Kind = int.Parse(dt.Rows[i]["id_Kind"].ToString());
                listMenu.Add(menu);
            }

            return listMenu;
        }

        public static List<DTO.Menu_DTO> GetInfoMenuByID(int id)
        {
            string stringquery = "select * from MENU where Id_nenu = " + id;
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.ExcuteQuery(stringquery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO.Menu_DTO> listInfo = new List<DTO.Menu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO.Menu_DTO menu = new DTO.Menu_DTO();
                menu.Id = int.Parse(dt.Rows[i]["Id_nenu"].ToString());
                menu.Name = dt.Rows[i]["name"].ToString();
                menu.Price = float.Parse(dt.Rows[i]["unit_Price"].ToString());
                menu.Amout = int.Parse(dt.Rows[i]["amout"].ToString());
                menu.Kind = int.Parse(dt.Rows[i]["id_Kind"].ToString());
                listInfo.Add(menu);
            }

            return listInfo;
        }

        public static bool AddMenu(Menu_DTO m)
        {
            string query = string.Format(@"insert into MENU values(N'{0}', {1}, {2}, {3})", m.Name, m.Kind, m.Price, m.Amout);
            con = DataProvider.OpenConnection();
            bool kq = DataProvider.ExcuteNonQuery(query, con);
            //DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool EditMenu(Menu_DTO m)
        {
            string query = string.Format(@"update MENU set name=N'{0}',id_Kind={1},unit_Price={2},amout={3} where Id_nenu={4}", m.Name, m.Kind, m.Price, m.Amout, m.Id);
            con = DataProvider.OpenConnection();
            bool kq = DataProvider.ExcuteNonQuery(query, con);
            //DataProvider.DongKetNoi(con);
            return kq;
        }

       
        public static bool DeleteMenu(int id)
        {
            string query = string.Format(@"delete from MENU where Id_nenu= " + id);
            con = DataProvider.OpenConnection();
            bool kq = DataProvider.ExcuteNonQuery(query, con);
            //DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool ImportGoods(int count, int id)
        {
            
            string query = string.Format(@"update MENU set amout = amout + " + count + " where Id_nenu =" + id);
            con = DataProvider.OpenConnection();
            bool kq = DataProvider.ExcuteNonQuery(query, con);
            //DataProvider.DongKetNoi(con);
            return kq;
        }

    }
}
