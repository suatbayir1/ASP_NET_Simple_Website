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
    public partial class Mesajlar : System.Web.UI.Page
    {
        sqlBaglanti con = new sqlBaglanti();

        protected void Page_Load(object sender, EventArgs e)
        {
            Panel2.Visible = false; 

            SqlCommand cmd = new SqlCommand("select * from Tbl_Mesajlar",con.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            DataList1.DataSource = dr;
            DataList1.DataBind();
            con.baglanti().Close();
        }

        protected void btnAc_Click1(object sender, EventArgs e)
        {

        }

        protected void btnAc_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;
        }

        protected void btnKapat_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
        }
    }
}