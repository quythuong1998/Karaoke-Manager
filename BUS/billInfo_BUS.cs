using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class billInfo_BUS
    {
        public static List<DTO.billInFo_DTO> GetListBillInfo(int id)
        {
            return DAO.billInfo_DAO.GetListBillInfo(id);
        }

        public static void AddBillInfo(int idBill, int idMenu, int count)
        {
            DAO.billInfo_DAO.AddBillInfo(idBill, idMenu, count);
        }

        
    }
}
