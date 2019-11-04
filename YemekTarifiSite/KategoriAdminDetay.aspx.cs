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
    public partial class KategoriAdminDetay : System.Web.UI.Page
    {
        sqlBaglanti con = new sqlBaglanti();
        string Kategoriid = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            Kategoriid = Request.QueryString["Kategoriid"];

            if (!Page.IsPostBack)
            {
                SqlCommand cmd = new SqlCommand("select * from Tbl_Kategoriler where Kategoriid=@p1", con.baglanti());
                cmd.Parameters.AddWithValue("@p1", Kategoriid);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtKategoriAd.Text = dr["KategoriAd"].ToString();
                    txtKategoriAdet.Text = dr["KategoriAdet"].ToString();
                }
                con.baglanti().Close(); 
            }
        }

        protected void btnKategoriGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Tbl_Kategoriler SET KategoriAd=@p1,KategoriAdet=@p2  where Kategoriid=@p3", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtKategoriAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtKategoriAdet.Text);
            cmd.Parameters.AddWithValue("@p3", Kategoriid);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
        }
    }
}