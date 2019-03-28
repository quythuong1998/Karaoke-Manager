using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class itemInBill_DAO
    {
        static SqlConnection con;
        public static List<DTO.itemInBill_DTO> GetItemOfRoom(int id)
        {
            string stringquery = "select m.name, bi.count_menu, m.unit_Price, m.unit_Price * bi.count_menu As ToMoney from BILL as b, BILL_INFO as bi, MENU as m, ROOM as r where bi.id_Bill = b.id_Bill and bi.Id_nenu = m.Id_nenu and r.id_Room = b.id_Room and r.status = 1 and b.payment_Status = 0 and r.id_Room =" + id;
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.ExcuteQuery(stringquery, con);
            
            //if (dt.Rows.Count == 0)
            //{
            //    return null;
            //}

            List<DTO.itemInBill_DTO> listItem = new List<DTO.itemInBill_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO.itemInBill_DTO item = new DTO.itemInBill_DTO();
                item.Name = dt.Rows[i]["name"].ToString();
                item.Amout = int.Parse(dt.Rows[i]["count_menu"].ToString());
                item.Price = float.Parse(dt.Rows[i]["unit_Price"].ToString());
                item.ToMoney = float.Parse(dt.Rows[i]["ToMoney"].ToString());
                listItem.Add(item);
            }
            return listItem;
        }
    }
}
