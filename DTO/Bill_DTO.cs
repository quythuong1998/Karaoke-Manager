using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill_DTO
    {
        private int id;
        private DateTime timeIn;
        private DateTime timeOut;
        private int paymentStatus;

        public Bill_DTO(int id, DateTime timeIn, DateTime timeOut, int paymentStatus)
        {
            this.Id = id;
            this.TimeIn = timeIn;
            this.TimeOut = timeOut;
            this.PaymentStatus = paymentStatus;
        }

        public int Id { get => id; set => id = value; }
        public DateTime TimeIn { get => timeIn; set => timeIn = value; }
        public DateTime TimeOut { get => timeOut; set => timeOut = value; }
        public int PaymentStatus { get => paymentStatus; set => paymentStatus = value; }
    }
}
