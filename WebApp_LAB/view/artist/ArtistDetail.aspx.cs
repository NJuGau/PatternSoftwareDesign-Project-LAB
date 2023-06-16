using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_LAB.ado_model;
using WebApp_LAB.controller;

namespace WebApp_LAB.view.artist
{
    public partial class ArtistDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int artistId = Convert.ToInt32(Request.QueryString["artistId"]);
            Artist a = ArtistController.GetArtistByID(artistId);
            artistImg.ImageUrl = "~/assets/artists/" + a.ArtistImage;
            artistName.Text = a.ArtistName;

            if (Session["User"] != null && ((Customer)Session["User"]).CustomerRole.Equals("Admin"))
            {
                insertBtn.Visible = true;
            }

            if (!IsPostBack)
            {
                CardRepeater.DataSource = AlbumController.getAlbumByArtistID(artistId);
                CardRepeater.DataBind();
            }
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            int artistId = Convert.ToInt32(Request.QueryString["artistId"]);
            Response.Redirect("~/view/album/InsertAlbum.aspx?artistId=" + artistId);
        }

        protected void albumCard_Click(object sender, EventArgs e)
        {
            LinkButton card = (LinkButton)sender;
            string albumId = card.CommandArgument;
            Response.Redirect("~/view/album/AlbumDetail.aspx?albumId=" + albumId);
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            string artistId = Request.QueryString["artistId"];
            Button btn = (Button)sender;
            string albumId = btn.CommandArgument;
            Response.Redirect("~/view/album/UpdateAlbum.aspx?artistId=" + artistId + "&albumId=" + albumId);
        }
        
        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            int artistId = Convert.ToInt32(Request.QueryString["artistId"]);
            Button btn = (Button)sender;
            string id = btn.CommandArgument;
            string path = Server.MapPath("~/assets/albums/" + AlbumController.GetAlbumByID(Convert.ToInt32(id)).AlbumImage);
            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                file.Delete();
            }
            AlbumController.RemoveAlbumByID(Convert.ToInt32(id));
            Response.Redirect("~/view/artist/ArtistDetail.aspx?artistId=" + artistId);
        }

        protected void CardRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if ((Session["User"] != null && ((Customer)Session["User"]).CustomerRole.Equals("Custo")) || Session["User"] == null)
            {
                (e.Item.FindControl("updateBtn") as Control).Visible = false;
                (e.Item.FindControl("deleteBtn") as Control).Visible = false;
            }
        }
    }
}