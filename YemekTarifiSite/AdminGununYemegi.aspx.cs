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
    public partial class AdminGununYemegi : System.Web.UI.Page
    {
        sqlBaglanti con = new sqlBaglanti();
        string islem = "";
        string Yemekid = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            Yemekid = Request.QueryString["Yemekid"];
            islem = Request.QueryString["islem"];

            if (islem == "sec")
            {
                // önceki günün yemeğini çıkar
                SqlCommand cikar = new SqlCommand("update Tbl_Yemekler set Durum=0 where Durum=1", con.baglanti());
                cikar.ExecuteNonQuery();
                con.baglanti().Close();

                // yeni günün yemeğini seç
                SqlCommand guncelle = new SqlCommand("update Tbl_Yemekler set Durum=1 where Yemekid=@p1", con.baglanti());
                guncelle.Parameters.AddWithValue("@p1", Yemekid);
                guncelle.ExecuteNonQuery();
                con.baglanti().Close();
            }

            Panel2.Visible = false;

            SqlCommand cmd = new SqlCommand("select * from Tbl_Yemekler",con.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            DataList1.DataSource = dr;
            DataList1.DataBind();
            con.baglanti().Close();
        }

        protected void btnAc_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;
        }

        protected void btnKapat_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
        }
    }
}