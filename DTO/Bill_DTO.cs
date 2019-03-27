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
        }

        public Bill_DTO(int id, DateTime timeIn, DateTime timeOut, int paymentStatus)
        {
            this.Id = id;
            this.TimeIn = timeIn;
            this.TimeOut = timeOut;
            this.PaymentStatus = paymentStatus;
           
        }

        public int Id { get => id; set => id = value; }
        public DateTime? TimeIn { get => timeIn; set => timeIn = value; }
        public DateTime? TimeOut { get => timeOut; set => timeOut = value; }
        public int PaymentStatus { get => paymentStatus; set => paymentStatus = value; }
        public int TimeUse { get => timeUse; set => timeUse = value; }
    }
}
