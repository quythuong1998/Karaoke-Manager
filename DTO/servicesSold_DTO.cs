using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class servicesSold_DTO
    {
        private string nameOfRoomBuy;
        private string nameOfServices;
        private int count;
        private float total_original_price;
        private float total_sale_price;
        private float revenue;

        public string NameOfRoomBuy { get => nameOfRoomBuy; set => nameOfRoomBuy = value; }
        public string NameOfServices { get => nameOfServices; set => nameOfServices = value; }
        public int Count { get => count; set => count = value; }
        public float Total_original_price { get => total_original_price; set => total_original_price = value; }
        public float Total_sale_price { get => total_sale_price; set => total_sale_price = value; }
        public float Revenue { get => revenue; set => revenue = value; }
    }
}
