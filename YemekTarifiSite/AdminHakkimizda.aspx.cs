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
    public partial class AdminHakkimizda : System.Web.UI.Page
    {
        sqlBaglanti con = new sqlBaglanti();

        protected void Page_Load(object sender, EventArgs e)
        {
            Panel2.Visible = false;

            if (!Page.IsPostBack)
            {
                // Hakkımızda yazısını getirme
                SqlCommand cmd = new SqlCommand("select *from Tbl_Hakkımızda", con.baglanti());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TextBox1.Text = dr["Metin"].ToString();
                }
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Hakkımızda metni güncelleme
            SqlCommand cmd = new SqlCommand("update Tbl_Hakkımızda set Metin=@p1", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", TextBox1.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
        }
    }
}