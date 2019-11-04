using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace YemekTarifiSite
{
    public partial class Anasayfa : System.Web.UI.Page
    {
        sqlBaglanti bgl = new sqlBaglanti();

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_Yemekler inner join Tbl_Kategoriler on Tbl_Kategoriler.Kategoriid = Tbl_Yemekler.Kategoriid ",bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            DataList2.DataSource = dr;
            DataList2.DataBind();
        }
    }
}