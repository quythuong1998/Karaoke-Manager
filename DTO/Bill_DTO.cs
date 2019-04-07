using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill_DTO
    {
        private int id;
        private DateTime? timeIn;
        private DateTime? timeOut;
        private int paymentStatus;
        private DataRow dataRow;
        private int timeUse;
        private float room_Fee;
        private float services_Fee;
        private int discount;
        private float total_Money;

        public Bill_DTO()
        {
        }

        public Bill_DTO(DataRow row)
        {
            this.Id = (int)row["id_Bill"];
            this.TimeIn = (DateTime?)row["time_In"];
            var gioratmp = row["time_Out"];
            if (gioratmp.ToString() != "")
                this.TimeOut = (DateTime?)gioratmp;
            this.PaymentStatus = (int)row["Payment_Status"];
            this.Discount = (int)row["discount"];
        }

        public int Id { get => id; set => id = value; }
        public DateTime? TimeIn { get => timeIn; set => timeIn = value; }
        public DateTime? TimeOut { get => timeOut; set => timeOut = value; }
        public int PaymentStatus { get => paymentStatus; set => paymentStatus = value; }
        public int TimeUse { get => timeUse; set => timeUse = value; }
        public int Discount { get => discount; set => discount = value; }
        public float Room_Fee { get => room_Fee; set => room_Fee = value; }
        public float Services_Fee { get => services_Fee; set => services_Fee = value; }
        public float Total_Money { get => total_Money; set => total_Money = value; }
    }
}
