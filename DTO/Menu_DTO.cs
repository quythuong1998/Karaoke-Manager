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
        private float price;
        private int amout;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public int Amout { get => amout; set => amout = value; }
    }
}
