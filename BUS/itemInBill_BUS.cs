using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class itemInBill_BUS
    {
        public static List<DTO.itemInBill_DTO> GetItemOfRoom(int id)
        {
            return DAO.itemInBill_DAO.GetItemOfRoom(id);
        }

        public static List<DTO.itemInBill_DTO> LoadItemOfRoomJustPaid()
        {
            return DAO.itemInBill_DAO.LoadItemOfRoomJustPaid();
        }
    }
}
