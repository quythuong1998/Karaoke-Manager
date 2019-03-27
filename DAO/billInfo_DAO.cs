using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace DAO
{
    public class billInfo_DAO
    {
        static SqlConnection con;
        public static List<DTO.billInFo_DTO> GetListBillInfo(int id)
        {
            string stringquery = "select * from dbo.chitiethoadon where mahoadon = " + id;
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.ExcuteQuery(stringquery, con);

            List<DTO.billInFo_DTO> listBillInfo = new List<DTO.billInFo_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO.billInFo_DTO bi = new DTO.billInFo_DTO();
                bi.Id = int.Parse(dt.Rows[i]["id_Bill_Info"].ToString());
                bi.IdBill = int.Parse(dt.Rows[i]["id_Bill"].ToString());
                bi.IdMenu = int.Parse(dt.Rows[i]["id_menu"].ToString());
                bi.Count = int.Parse(dt.Rows[i]["count_menu"].ToString());
                listBillInfo.Add(bi);
            }
            return listBillInfo;
        }

        public static void AddBillInfo(int idBill, int idMenu, int count)
        {
            string stringquery = "Proc_addBillInfo " + idBill + ", " + idMenu + ", " + count;
            
            con = DataProvider.OpenConnection();
            //MessageBox.Show(stringquery.ToString());
            DataProvider.ExcuteNonQuery(stringquery, con);
        }
    }
}
