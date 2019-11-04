using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace YemekTarifiSite
{
    public class sqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UPH9EF9\SQLEXPRESS; Initial Catalog=Dbo_yemektarifi; Integrated Security=True");
            con.Open();
            return con;
        }
    }
}