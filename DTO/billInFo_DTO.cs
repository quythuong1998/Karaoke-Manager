using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class billInFo_DTO
    {
        private int id;
        private int idBill;
        private int idMenu;
        private int count;

        public billInFo_DTO()
        {
        }

        public billInFo_DTO(int id, int idBill, int idMenu, int count)
        {
            this.Id = id;
            this.IdBill = idBill;
            this.IdMenu = idMenu;
            this.Count = count;
        }

        public int Id { get => id; set => id = value; }
        public int IdBill { get => idBill; set => idBill = value; }
        public int IdMenu { get => idMenu; set => idMenu = value; }
        public int Count { get => count; set => count = value; }
    }
}
