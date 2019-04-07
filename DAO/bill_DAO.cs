using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class bill_DAO
    {
        //thiet lap tra ra id cua hoa don
        static SqlConnection con;
        public static int GetBillNotPaymentByIdRoom(int id)
        {
            string stringquery = "select * from BILL where id_Room =" + id + "and payment_Status = 0  ";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.ExcuteQuery(stringquery, con);

            if (dt.Rows.Count > 0)
            {
                DTO.Bill_DTO b = new DTO.Bill_DTO(dt.Rows[0]);
                return b.Id;
            }
            return -1; //id no la -1: ko co thang nao het
            //thanh cong thi se la stt hoa don, fail thi -1 
        }
        //van de nam o dayyyy !!!!!

        //public static List<DTO.Bill_DTO> GetListBill(int id)
        //{
        //    string stringquery = "select * from BILL where id_Room =" + id + "and payment_Status = 0  ";
        //    DataTable dt = DataProvider.ExcuteQuery(stringquery, con);

        //    List<DTO.Bill_DTO> listBill = new List<DTO.Bill_DTO>();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        DTO.Bill_DTO b = new DTO.Bill_DTO();
        //        b.Id = int.Parse(dt.Rows[i]["id_Bill"].ToString());
        //        b.TimeIn = (DateTime)dt.Rows[i]["time_In"]);
        //    b.TimeOut = (DateTime)dt.Rows[i]["time_Out"];
        //    b.PaymentStatus = int.Parse(dt.Rows[i]["payment_Status"].ToString());
        //    listBill.Add(b);
        //}
        //    return listBill;
        
        
        public static void AddBill(int idRoom)
        {
            string stringquery = "EXEC Proc_addBill " + idRoom;
            con = DataProvider.OpenConnection();
            DataProvider.ExcuteNonQuery(stringquery, con);
        }


        public static int getMaxIdBill()
        {
            string stringquery = "select max(id_Bill) from BILL";
            con = DataProvider.OpenConnection();
            try
            {
                return (int) DataProvider.ExecuteScalar(stringquery, con);
            }
            catch
            {
                return 1;
            }
        }

        public static List<DTO.Bill_DTO> GetBillByIdRoom(int id)
        {
            string stringquery = "select *, DATEDIFF(MINUTE, time_In, GETDATE()) as timeUse from dbo.BILL where payment_Status = 0 and id_Room = " + id;
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.ExcuteQuery(stringquery, con);

            List<DTO.Bill_DTO> listBill = new List<DTO.Bill_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO.Bill_DTO b = new DTO.Bill_DTO();
                b.Id = int.Parse(dt.Rows[i]["id_Bill"].ToString());
                b.TimeIn = (DateTime?)dt.Rows[i]["time_In"];
                var gioratmp = dt.Rows[i]["time_Out"];
                if (gioratmp.ToString() != "")
                    b.TimeOut = (DateTime?)gioratmp;
                b.PaymentStatus = int.Parse(dt.Rows[i]["payment_Status"].ToString());
                b.TimeUse = int.Parse(dt.Rows[i]["timeUse"].ToString());
                //b.Discount = int.Parse(dt.Rows[i]["discount"].ToString());
                listBill.Add(b);
            }
            return listBill;
        }

        public static void payment(int id, int discount, float ser_fee, float r_Fee)
        {
            string stringquery = "update BILL set time_Out = getdate(), payment_Status = 1, discount = " + discount + ", service_Fee = " + ser_fee + ", room_Fee = " + r_Fee + " where id_Bill = " + id;
            con = DataProvider.OpenConnection();
            DataProvider.ExcuteQuery(stringquery, con);
        }

        public static List<DTO.Bill_DTO> GetAllBillByDate(string date)
        {
            string stringquery = "select b.id_Bill,r.name, b.time_In, b.time_Out,DATEDIFF(MINUTE, b.time_In, b.time_Out) as time_Use, room_Fee,service_Fee, b.discount, (room_Fee + service_Fee) + (((room_Fee + service_Fee) * 0.1) - (((room_Fee + service_Fee) + ((room_Fee + service_Fee) * 0.1)) * discount) / 100.0)  as total_money from bill as b, ROOM as r where payment_Status = 1 and b.id_Room = r.id_Room and time_In between '"+ date +"' and '" + date + " 23:59:59'";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.ExcuteQuery(stringquery, con);

            List<DTO.Bill_DTO> listBill = new List<DTO.Bill_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO.Bill_DTO b = new DTO.Bill_DTO();
                b.Id = int.Parse(dt.Rows[i]["id_Bill"].ToString());
                b.TimeIn = (DateTime?)dt.Rows[i]["time_In"];
                var gioratmp = dt.Rows[i]["time_Out"];
                if (gioratmp.ToString() != "")
                    b.TimeOut = (DateTime?)gioratmp;
                //b.PaymentStatus = int.Parse(dt.Rows[i]["payment_Status"].ToString());
                b.TimeUse = int.Parse(dt.Rows[i]["time_Use"].ToString());
                b.Room_Fee = float.Parse(dt.Rows[i]["room_Fee"].ToString());
                b.Services_Fee = float.Parse(dt.Rows[i]["service_Fee"].ToString());
                b.Discount = int.Parse(dt.Rows[i]["discount"].ToString());
                b.Total_Money = float.Parse(dt.Rows[i]["total_money"].ToString());
                listBill.Add(b);
            }
            return listBill;
        }

    }
}
