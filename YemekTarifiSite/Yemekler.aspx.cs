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
    public partial class Yemekler : System.Web.UI.Page
    {
        sqlBaglanti con = new sqlBaglanti();
        string islem = "";
        string Yemekid = "";

        protected void Page_Load(object sender, EventArgs e)
        {

                Panel2.Visible = false;
                Panel3.Visible = false; 
            
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Tbl_Yemekler", con.baglanti());
                SqlDataReader dr = cmd.ExecuteReader();
                DataList1.DataSource = dr;
                DataList1.DataBind();
                con.baglanti().Close();
            }
            catch (Exception)
            {
            }
            if (!Page.IsPostBack)
            {
                Yemekid = Request.QueryString["Yemekid"];
                islem = Request.QueryString["islem"];

                // Kategorileri dropdownliste çekme

                SqlCommand cmd2 = new SqlCommand("Select * From Tbl_Kategoriler", con.baglanti());
                SqlDataReader dr2 = cmd2.ExecuteReader();
                ddKategori.DataTextField = "KategoriAd";     // listede gözükecek değer
                ddKategori.DataValueField = "Kategoriid";    // arkaplandan işlem yapılacak değer
                ddKategori.DataSource = dr2;
                ddKategori.DataBind(); 
            }

            if (islem == "sil")
            {
                SqlCommand cmd = new SqlCommand("delete from Tbl_Yemekler where Yemekid=@p1", con.baglanti());
                cmd.Parameters.AddWithValue("@p1", Yemekid);
                cmd.ExecuteNonQuery();
                con.baglanti().Close();
            }
        }

        protected void btnAc_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;
        }

        protected void btnKapat_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
        }

        protected void btnKategoriEkleAc_Click(object sender, EventArgs e)
        {
            Panel3.Visible = true;
        }

        protected void btnKategoriEkleKapat_Click(object sender, EventArgs e)
        {
            Panel3.Visible = false;
        }

        protected void btnKategoriEkle0_Click(object sender, EventArgs e)
        {
            // Yemek Ekleme
            SqlCommand cmd = new SqlCommand("insert into Tbl_Yemekler(YemekAd,YemekMalzeme,YemekTarif,Kategoriid) values(@p1,@p2,@p3,@p4)", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtKategoriAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtMalzemeler.Text);
            cmd.Parameters.AddWithValue("@p3", txtTarif.Text);
            cmd.Parameters.AddWithValue("@p4", ddKategori.SelectedValue);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();

            // Kategori Sayısını Arttırma
            SqlCommand cmd2 = new SqlCommand("update Tbl_Kategoriler set KategoriAdet=KategoriAdet+1 where Kategoriid=@k1", con.baglanti());
            cmd2.Parameters.AddWithValue("@k1", ddKategori.SelectedValue);
            cmd2.ExecuteNonQuery();
            con.baglanti().Close();
        }
    }
}