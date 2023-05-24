﻿using System;
using System.Collections.Generic;
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
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            Artist a = ArtistController.GetArtistByID(id);
            artistImg.ImageUrl = "~/assets/artists/" + a.ArtistImage;
            artistName.Text = a.ArtistName;

            string role = "";
            if (Request.Cookies["user_cookie"] != null)
            {
                int userId = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                Customer user = CustomerController.getCustomerProfile(userId);
                Session["User"] = user;
                role = user.CustomerRole;
            }

            if (Session["User"] != null && role.Equals("Admin"))
            {
                insertBtn.Visible = true;
            }

            if (!IsPostBack)
            {
                CardRepeater.DataSource = AlbumController.getAlbumByArtistID(id);
                CardRepeater.DataBind();
            }
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            Response.Redirect("~/view/album/InsertAlbum.aspx?id=" + id);
        }

        protected void albumCard_Click(object sender, EventArgs e)
        {
            LinkButton card = (LinkButton)sender;
            string id = card.CommandArgument;
            Response.Redirect("~/view/album/AlbumDetail.aspx?id=" + id);
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            string artistId = Request.QueryString["Id"];
            Button btn = (Button)sender;
            string id = btn.CommandArgument;
            Response.Redirect("~/view/album/UpdateAlbum.aspx?id=" + id + "&artistId=" + artistId);
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            int artistId = Convert.ToInt32(Request.QueryString["Id"]);
            Button btn = (Button)sender;
            string id = btn.CommandArgument;
            AlbumController.RemoveAlbumByID(Convert.ToInt32(id));
            Response.Redirect("~/view/artist/ArtistDetail.aspx?id=" + artistId);
        }

        protected void CardRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            string role = "";
            if (Request.Cookies["user_cookie"] != null)
            {
                int id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                Customer user = CustomerController.getCustomerProfile(id);
                Session["User"] = user;
                role = user.CustomerRole;
            }

            if ((Session["User"] != null && role.Equals("Custo")) || Session["User"] == null)
            {
                (e.Item.FindControl("updateBtn") as Control).Visible = false;
                (e.Item.FindControl("deleteBtn") as Control).Visible = false;
            }
        }
    }
}