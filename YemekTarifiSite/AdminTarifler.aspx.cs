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
    public partial class AdminTarifler : System.Web.UI.Page
    {
        sqlBaglanti con = new sqlBaglanti();

        protected void Page_Load(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel4.Visible = false;

            //onaysız tarif listesi
            SqlCommand cmd = new SqlCommand("select * from Tbl_Tarifler where TarifDurum=0", con.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            DataList1.DataSource = dr;
            DataList1.DataBind();
            con.baglanti().Close();

            //onaylı yorum listesi
            SqlCommand cmd2 = new SqlCommand("select * from Tbl_Tarifler where TarifDurum=1", con.baglanti());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            DataList2.DataSource = dr2;
            DataList2.DataBind();
            con.baglanti().Close();
        }

        protected void btnAc_Click(object sender, EventArgs e)
        {

        }

        protected void btnKapat_Click(object sender, EventArgs e)
        {

        }

        protected void btnAc_Click1(object sender, EventArgs e)
        {
            Panel2.Visible = true;
        }

        protected void btnKapat_Click1(object sender, EventArgs e)
        {
            Panel2.Visible = false;
        }

        protected void btnAc0_Click(object sender, EventArgs e)
        {
            Panel4.Visible = true;
        }

        protected void btnKapat0_Click(object sender, EventArgs e)
        {
            Panel4.Visible = false;
        }
    }
}