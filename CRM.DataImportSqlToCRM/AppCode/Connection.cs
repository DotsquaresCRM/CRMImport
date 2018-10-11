using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DSTools.MSSqlToCRMImport.AppCode
{
    public static class Connection
    {
        public static string ConnectionString;
        public static string UserID;
        public static SecureString Password;
        public static string ServerName;
        public static string Database;
    }
}
