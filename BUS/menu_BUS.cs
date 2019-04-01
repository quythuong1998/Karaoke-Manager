using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class menu_BUS
    {
        public static List<DTO.Menu_DTO> GetMenus(int id)
        {
            return DAO.menu_DAO.GetMenuByID(id);
        }

        public static List<DTO.Menu_DTO> GetInfoMenuByID(int id)
        {
            return DAO.menu_DAO.GetInfoMenuByID(id);
        }

        public static bool AddMenu(DTO.Menu_DTO m)
        {
            return DAO.menu_DAO.AddMenu(m);
        }

        public static bool EditMenu(DTO.Menu_DTO m)
        {
            return DAO.menu_DAO.EditMenu(m);
        }
        public static bool DeleteMenu(int id)
        {
            return DAO.menu_DAO.DeleteMenu(id);
        }


        public static bool ImportGoods(int count, int id)
        {
            return DAO.menu_DAO.ImportGoods(count, id);
        }
        
    }
}
