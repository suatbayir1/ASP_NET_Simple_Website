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
    public partial class YemekDuzenle : System.Web.UI.Page
    {
        sqlBaglanti con = new sqlBaglanti();
        string Yemekid = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            Yemekid = Request.QueryString["Yemekid"];

            if (!Page.IsPostBack)
            {
                SqlCommand cmd = new SqlCommand("select * from Tbl_Yemekler where Yemekid=@p1", con.baglanti());
                cmd.Parameters.AddWithValue("@p1", Yemekid);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtYemekAd.Text = dr["YemekAd"].ToString();
                    txtMalzemeler.Text = dr["YemekMalzeme"].ToString();
                    txtTarif.Text = dr["YemekTarif"].ToString();
                }
                if (!Page.IsPostBack)
                {
                    SqlCommand cmd2 = new SqlCommand("select * from Tbl_Kategoriler", con.baglanti());
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    ddKategori.DataTextField = "KategoriAd";
                    ddKategori.DataValueField = "Kategoriid";
                    ddKategori.DataSource = dr2;
                    ddKategori.DataBind();
                    con.baglanti().Close();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // file upload daki veriyi kaydetme
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("/resimler/" + FileUpload1.FileName)); 
            }

            SqlCommand cmd = new SqlCommand("update Tbl_Yemekler set YemekAd=@p1, YemekMalzeme=@p2, YemekTarif=@p3, Kategoriid=@p4 , YemekResim=@p6 where Yemekid=@p5", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtYemekAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtMalzemeler.Text);
            cmd.Parameters.AddWithValue("@p3", txtTarif.Text);
            cmd.Parameters.AddWithValue("@p4", ddKategori.SelectedValue);
            cmd.Parameters.AddWithValue("@p6", "~/resimler/" + FileUpload1.FileName);
            cmd.Parameters.AddWithValue("@p5", Yemekid);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
        }
    }
}