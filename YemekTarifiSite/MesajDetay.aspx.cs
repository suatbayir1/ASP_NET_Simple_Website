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
    public partial class MesajDetay : System.Web.UI.Page
    {
        sqlBaglanti con = new sqlBaglanti();
        string Mesajid = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            Mesajid = Request.QueryString["Mesajid"];

            SqlCommand cmd = new SqlCommand("select * from Tbl_Mesajlar where Mesajid=@p1",con.baglanti());
            cmd.Parameters.AddWithValue("@p1", Mesajid);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtMesajGonderen.Text = dr["MesajGonderen"].ToString();
                txtMesajBaslik.Text = dr["MesajBaslik"].ToString();
                txtEmail.Text = dr["MesajMail"].ToString();
                txtIcerik.Text = dr["MesajIcerik"].ToString();
            }
            con.baglanti().Close();
        }
    }
}