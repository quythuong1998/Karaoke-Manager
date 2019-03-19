using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Kind_BUS
    {
        public static List<DTO.Kind_DTO> Getkinds()
        {
            return DAO.Kind_DAO.GetKindOfDkink();
        }
    }
}
