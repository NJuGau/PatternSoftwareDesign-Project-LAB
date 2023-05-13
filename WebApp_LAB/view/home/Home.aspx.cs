using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_LAB.view.home
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../artist/InsertArtist.aspx");
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../artist/UpdateArtist.aspx");
        }
    }
}