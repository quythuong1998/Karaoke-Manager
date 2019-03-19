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
    }
}
