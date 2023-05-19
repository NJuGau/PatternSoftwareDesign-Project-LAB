using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_LAB.controller;

namespace WebApp_LAB.view.home
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CardRepeater.DataSource = ArtistController.GetAllArtist();
            CardRepeater.DataBind();
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/view/artist/InsertArtist.aspx");
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string id = btn.CommandArgument;
            Response.Redirect("~/view/artist/UpdateArtist.aspx?id=" + id);
            
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string id = btn.CommandArgument;
            ArtistController.RemoveArtistByID(Convert.ToInt32(id));
        }

        protected void artistCard_Click(object sender, EventArgs e)
        {
            LinkButton card = (LinkButton)sender;
            string id = card.CommandArgument;
            Response.Redirect("~/view/artist/ArtistDetail.aspx?id=" + id);
        }
    }
}