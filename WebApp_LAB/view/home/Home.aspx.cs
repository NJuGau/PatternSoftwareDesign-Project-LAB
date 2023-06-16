using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_LAB.ado_model;
using WebApp_LAB.controller;

namespace WebApp_LAB.view.home
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["user_cookie"] != null && Session["User"] == null)
            {
                int userId = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                Customer c = CustomerController.getCustomerProfile(userId);
                Session["User"] = c;
            }

            if (Session["User"] != null && ((Customer)Session["User"]).CustomerRole.Equals("Admin"))
            {
                insertBtn.Visible = true;
            }

            if (!IsPostBack)
            {
                CardRepeater.DataSource = ArtistController.GetAllArtist();
                CardRepeater.DataBind();
            }
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/view/artist/InsertArtist.aspx");
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string artistId = btn.CommandArgument;
            Response.Redirect("~/view/artist/UpdateArtist.aspx?artistId=" + artistId);
        }

        protected void deleteAlbumImageOnCascade(int artistId)
        {
            List<Album> albumList = AlbumController.getAlbumByArtistID(artistId);
            foreach(Album album in albumList)
            {
                string path = Server.MapPath("~/assets/albums/" + album.AlbumImage);
                FileInfo file = new FileInfo(path);
                if (file.Exists)
                {
                    file.Delete();
                }
            }
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string artistId = btn.CommandArgument;            
            string path = Server.MapPath("~/assets/artists/" + ArtistController.GetArtistByID(Convert.ToInt32(artistId)).ArtistImage);
            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                file.Delete();
            }
            deleteAlbumImageOnCascade(Convert.ToInt32(artistId));
            ArtistController.RemoveArtistByID(Convert.ToInt32(artistId));
            Response.Redirect("~/view/home/Home.aspx");
        }

        protected void artistCard_Click(object sender, EventArgs e)
        {
            LinkButton card = (LinkButton)sender;
            string artistId = card.CommandArgument;
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