using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace YemekTarifiSite
{
    public partial class TarifOner : System.Web.UI.Page
    {
        sqlBaglanti bgl = new sqlBaglanti();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTarifOner_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_Tarifler(TarifAd,TarifMalzeme,TarifYapilis,TarifResim,TarifSahip,TarifSahipMail) VALUES(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", txtTarifAd.Text);
                cmd.Parameters.AddWithValue("@p2", txtTarifMalzemeler.Text);
                cmd.Parameters.AddWithValue("@p3", txtTarifYapilis.Text);
                cmd.Parameters.AddWithValue("@p4", fuTarihResim.FileName);
                cmd.Parameters.AddWithValue("@p5", txtTarifOneren.Text);
                cmd.Parameters.AddWithValue("@p6", txtMailAdres.Text);
                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();
                Response.Write("Tariniz alınmıştır. Yönetici tarafından onaylanırsa siteye eklenecektir..");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        } 
    }
}