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
    public partial class Yorumlar : System.Web.UI.Page
    {
        sqlBaglanti con = new sqlBaglanti();
        string Yorumid = "";
        string islem = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel4.Visible = false;

            // Onaylı Yorumlar Listeleme
            SqlCommand cmd = new SqlCommand("select * from Tbl_Yorumlar where YorumOnay=1",con.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            DataList1.DataSource = dr;
            DataList1.DataBind();
            con.baglanti().Close();

            //Onaysız Yorumlar Listeleme
            SqlCommand cmd3 = new SqlCommand("select * from Tbl_Yorumlar where YorumOnay=0", con.baglanti());
            SqlDataReader dr3 = cmd3.ExecuteReader();
            DataList2.DataSource = dr3;
            DataList2.DataBind();
            con.baglanti().Close();

            if (islem == "sil")
                {
                    SqlCommand cmd2 = new SqlCommand("delete from Tbl_Yorumlar where Yorumid=@p1",con.baglanti());
                    cmd2.Parameters.AddWithValue("@p1", Yorumid);
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel4.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel4.Visible = false;
        }

        protected void btnAc_Click1(object sender, EventArgs e)
        {
            Panel2.Visible = true;
        }

        protected void btnKapat_Click1(object sender, EventArgs e)
        {
            Panel2.Visible = false;
        }
    }
}