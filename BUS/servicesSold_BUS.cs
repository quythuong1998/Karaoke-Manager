using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class servicesSold_BUS
    {
        public static List<DTO.servicesSold_DTO> GetAllServicesSoldByDate(string date)
        {
            return DAO.servicesSold_DAO.GetAllServicesSoldByDate(date);
        }
    }
}
