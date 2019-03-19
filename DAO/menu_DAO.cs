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
                listMenu.Add(menu);
            }

            return listMenu;
        }


    }
}
