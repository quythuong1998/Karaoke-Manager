using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class Kind_DAO
    {
        static SqlConnection con;
        public static List<DTO.Kind_DTO> GetKindOfDkink()
        {
            string stringquery = "select * from KIND";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.ExcuteQuery(stringquery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<DTO.Kind_DTO> listKind = new List<DTO.Kind_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO.Kind_DTO kind = new DTO.Kind_DTO();
                kind.Id = int.Parse(dt.Rows[i]["id_Kind"].ToString());
                kind.Name = dt.Rows[i]["name"].ToString();
                listKind.Add(kind);
            }
            return listKind;
        }

    }
}
