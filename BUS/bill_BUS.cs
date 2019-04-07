using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class bill_BUS
    {
        public static int GetBillNotPaymentByIdRoom(int id)
        {
            return bill_DAO.GetBillNotPaymentByIdRoom(id);
        }

        public static void AddBill(int idRoom)
        {
            bill_DAO.AddBill(idRoom);
        }

        public static int getMaxIdBill()
        {
            return DAO.bill_DAO.getMaxIdBill();
        }

        public static List<DTO.Bill_DTO> GetBillByIdRoom(int id)
        {
            return DAO.bill_DAO.GetBillByIdRoom(id);
        }

        public static void Payment(int id, int discount, float ser_fee, float r_Fee)
        {
            DAO.bill_DAO.payment(id, discount,  ser_fee,  r_Fee);
        }

        public static List<DTO.Bill_DTO> GetAllBillByDate(string date)
        {
            return DAO.bill_DAO.GetAllBillByDate(date);
        }
    }
}
