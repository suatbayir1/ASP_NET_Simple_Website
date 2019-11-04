using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace YemekTarifiSite
{
    public partial class KategoriDetay : System.Web.UI.Page
    {
        sqlBaglanti con = new sqlBaglanti();
        string Kategoriid = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            Kategoriid = Request.QueryString["Kategoriid"];
            SqlCommand cmd = new SqlCommand("select * from Tbl_Yemekler where Kategoriid=@p1", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", Kategoriid);
            SqlDataReader dr = cmd.ExecuteReader();
            DataList2.DataSource = dr;
            DataList2.DataBind();
            con.baglanti().Close();
        }
    }
}