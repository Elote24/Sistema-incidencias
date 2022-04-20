using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Configuration;

namespace Gestion
{
    class Utileria
    {
        public static string GetConnectionString()
        {
            string strCadena = "";
            int numItems = ConfigurationManager.ConnectionStrings.Count;
            if (numItems > 0)
            {
                strCadena = ConfigurationManager.ConnectionStrings[numItems - 1].ConnectionString;
            }
            return strCadena;
        }
    }
}
