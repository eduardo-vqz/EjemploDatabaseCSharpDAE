using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDatabaseCSharpDAE.Core.Lib
{
    internal class DbConection
    {
        public static SqlConnection GetConnection()
        {
            var cs = System.Configuration.ConfigurationManager
                        .ConnectionStrings["SqlConn"].ConnectionString;
            return new SqlConnection(cs);
        }

    }
}
