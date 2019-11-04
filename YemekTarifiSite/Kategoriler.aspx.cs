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
    public partial class Kategoriler : System.Web.UI.Page
    {
        sqlBaglanti con = new sqlBaglanti();
        string id = "";
        string islem = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel3.Visible = false;

            if (!Page.IsPostBack)
            {
                id = Request.QueryString["Kategoriid"];
                islem = Request.QueryString["islem"];
            }

            // Listeleme
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Tbl_Kategoriler", con.baglanti());
                SqlDataReader dr = cmd.ExecuteReader();
                DataList1.DataSource = dr;
                DataList1.DataBind();
                con.baglanti().Close();
            }
            catch (Exception ex)
            {
            }

            //Silme
            if (islem=="sil")
            {
                SqlCommand cmd2 = new SqlCommand("delete from Tbl_Kategoriler where Kategoriid=@p1", con.baglanti());
                cmd2.Parameters.AddWithValue("@p1", id);
                cmd2.ExecuteNonQuery();
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

        protected void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Kategoriler(KategoriAd) values(@p1)", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtKategoriAd.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
        }
    }
}