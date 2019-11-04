using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace YemekTarifiSite
{
    public partial class YemekDetay : System.Web.UI.Page
    {
        sqlBaglanti bgl = new sqlBaglanti();
        string Yemekid="";

        protected void Page_Load(object sender, EventArgs e)
        {
            Yemekid = Request.QueryString["Yemekid"];

            SqlCommand cmd = new SqlCommand("Select YemekAd from Tbl_Yemekler Where Yemekid=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", Yemekid);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Label3.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            // Yorumları Listeleme
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Tbl_Yorumlar Where Yemekid=@p2", bgl.baglanti());
            cmd2.Parameters.AddWithValue("@p2", Yemekid);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            DataList2.DataSource = dr2;
            DataList2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Yorumlar(YorumAdSoyad,YorumMail,Yorumicerik,Yemekid) values(@p1,@p2,@p3,@p4)",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            cmd.Parameters.AddWithValue("@p2", txtEmail.Text);
            cmd.Parameters.AddWithValue("@p3", txtYorum.Text);
            cmd.Parameters.AddWithValue("@p4", Yemekid);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            
        }
    }
}