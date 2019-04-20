using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Menu_DTO
    {
        private int id;
        private string name;
        private float original_price;
        private float sale_price;
        private int amout;
        private int kind;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Original_price { get => original_price; set => original_price = value; }
        public int Amout { get => amout; set => amout = value; }
        public int Kind { get => kind; set => kind = value; }
        public float Sale_price { get => sale_price; set => sale_price = value; }
    }
}
