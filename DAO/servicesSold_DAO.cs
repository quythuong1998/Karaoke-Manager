using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class servicesSold_DAO
    {
        static SqlConnection con;
        public static List<DTO.servicesSold_DTO> GetAllServicesSoldByDate(string date)
        {
            string stringquery = "select r.name, m.name as nameSV, bi.count_menu, (m.original_Price *  bi.count_menu) as total_original_Price, (m.sale_Price *  bi.count_menu) as total_sale_Price, ((m.sale_Price *  bi.count_menu) - (m.original_Price *  bi.count_menu)) as revenue from BILL_INFO as bi, BILL as b, MENU as m, ROOM as r where b.id_Bill = bi.id_Bill and r.id_Room = b.id_Room and bi.Id_nenu = m.Id_nenu and b.payment_Status = 1 and time_In between '" + date + "' and '" + date + " 23:59:59'";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.ExcuteQuery(stringquery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<servicesSold_DTO> listServices = new List<servicesSold_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                servicesSold_DTO s = new servicesSold_DTO();
                s.NameOfRoomBuy = dt.Rows[i]["name"].ToString();
                s.NameOfServices = dt.Rows[i]["nameSV"].ToString();
                s.Count = int.Parse(dt.Rows[i]["count_menu"].ToString());
                s.Total_original_price = float.Parse(dt.Rows[i]["total_original_Price"].ToString());
                s.Total_sale_price = float.Parse(dt.Rows[i]["total_sale_Price"].ToString());
                s.Revenue = float.Parse(dt.Rows[i]["Revenue"].ToString());
                listServices.Add(s);
            }
            return listServices;
        }
    }
}
