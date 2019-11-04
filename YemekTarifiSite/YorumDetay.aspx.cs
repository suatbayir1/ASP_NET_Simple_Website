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
    public partial class YorumDetay : System.Web.UI.Page
    {
        sqlBaglanti con = new sqlBaglanti();
        string Yorumid = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            Yorumid = Request.QueryString["Yorumid"];

            if (!Page.IsPostBack)
            {
                SqlCommand cmd = new SqlCommand("Select YorumAdSoyad,Yorumicerik,YorumMail,Yemekad from Tbl_Yorumlar inner join Tbl_Yemekler on Tbl_Yorumlar.Yemekid = Tbl_Yemekler.Yemekid where Yorumid=@p1", con.baglanti());
                cmd.Parameters.AddWithValue("@p1", Yorumid);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtAdSoyad.Text = dr["YorumAdSoyad"].ToString();
                    txtEmail.Text = dr["YorumMail"].ToString();
                    txtIcerik.Text = dr["Yorumicerik"].ToString();
                    txtYemek.Text = dr["YemekAd"].ToString();
                }
                con.baglanti().Close(); 
            }
        }

        protected void btnOnayla_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Tbl_Yorumlar set YorumOnay=1 where Yorumid=@p1",con.baglanti());
            cmd.Parameters.AddWithValue("@p1", Yorumid);
            cmd.ExecuteReader();
            con.baglanti().Close();
            Response.Redirect("Yorumlar.aspx");
        }
    }
}