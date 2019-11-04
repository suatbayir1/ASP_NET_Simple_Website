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
    public partial class Iletisim : System.Web.UI.Page
    {
        sqlBaglanti con = new sqlBaglanti();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGonder_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Mesajlar(MesajGonderen,MesajMail,MesajBaslik,MesajIcerik) values (@p1,@p2,@p3,@p4)", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            cmd.Parameters.AddWithValue("@p2", txtEmail.Text);
            cmd.Parameters.AddWithValue("@p3", txtKonu.Text);
            cmd.Parameters.AddWithValue("@p4", txtMesaj.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
        }
    }
}