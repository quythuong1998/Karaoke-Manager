using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BackUpAndRestore_BUS
    {
        public static bool Backup(string path)
        {
            return DAO.BackUpAndRestore_DAO.Backup(path);
        }

        public static bool Restore(string path)
        {
            return DAO.BackUpAndRestore_DAO.Restore(path);
        }
    }
}
