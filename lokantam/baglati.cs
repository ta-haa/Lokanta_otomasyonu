using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_baslangic
{
    public class baglati
    {
        public static SqlConnection baglan = new SqlConnection(@"data source=MSI;initial catalog = csharp;integrated security=true");

        public static void CheckConnection (SqlConnection baglan)
        { 
            if(baglan.State == System.Data.ConnectionState.Closed)
            {
                baglan.Open();
            }
            else
            {

            }
        
        }

    }
}
