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
    public partial class TarifOnerDetay : System.Web.UI.Page
    {
        sqlBaglanti con = new sqlBaglanti();
        string Tarifid = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            Tarifid = Request.QueryString["Tarifid"];

            if (!Page.IsPostBack)
            {
                SqlCommand cmd = new SqlCommand("select * from Tbl_Tarifler where Tarifid=@p1", con.baglanti());
                cmd.Parameters.AddWithValue("@p1", Tarifid);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtTarifAd.Text = dr["TarifAd"].ToString();
                    txtMalzemeler.Text = dr["TarifMalzeme"].ToString();
                    txtOnerenMail.Text = dr["TarifSahipMail"].ToString();
                    txtYapilis.Text = dr["TarifYapilis"].ToString();
                    txtTarifOneren.Text = dr["TarifSahip"].ToString();
                }
                con.baglanti().Close();

                SqlCommand cmd2 = new SqlCommand("select *from Tbl_Kategoriler", con.baglanti());
                SqlDataReader dr2 = cmd2.ExecuteReader();
                DropDownList1.DataTextField = "KategoriAd";
                DropDownList1.DataValueField = "Kategoriid";
                DropDownList1.DataSource = dr2;
                DropDownList1.DataBind();
                con.baglanti().Close();
            }
        }

        protected void btnTarifOnayla_Click(object sender, EventArgs e)
        {
            //Durum Güncelleme
            SqlCommand cmd = new SqlCommand("update Tbl_Tarifler set TarifDurum=1 where Tarifid=@p1", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", Tarifid);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();

            //Yemeği Anasayfaya ekleme
            SqlCommand cmd2 = new SqlCommand("insert into Tbl_Yemekler(YemekAd,YemekMalzeme,YemekTarif,Kategoriid) values(@k1,@k2,@k3,@k4)", con.baglanti());
            cmd2.Parameters.AddWithValue("@k1", txtTarifAd.Text);
            cmd2.Parameters.AddWithValue("@k2", txtMalzemeler.Text);
            cmd2.Parameters.AddWithValue("@k3", txtYapilis.Text);
            cmd2.Parameters.AddWithValue("@k4", DropDownList1.SelectedValue);
            cmd2.ExecuteNonQuery();
            con.baglanti().Close();
        }
    }
}