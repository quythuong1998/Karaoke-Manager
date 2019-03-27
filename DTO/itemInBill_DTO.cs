using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class itemInBill_DTO
    {
        //private int id;
        private string name;
        private float price;
        private int amout;
        private float toMoney;

        public itemInBill_DTO()
        {
        }

        public itemInBill_DTO(string name, float price, int amout, float toMoney)
        {
            this.Name = name;
            this.Price = price;
            this.Amout = amout;
            this.ToMoney = toMoney;
        }

        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public int Amout { get => amout; set => amout = value; }
        public float ToMoney { get => toMoney; set => toMoney = value; }
    }
}
