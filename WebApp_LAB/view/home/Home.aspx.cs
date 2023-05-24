using System;
using System.Collections.Generic;
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
            string role = "";
            if (Request.Cookies["user_cookie"] != null)
            {
                int id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                Customer user = CustomerController.getCustomerProfile(id);
                Session["User"] = user;
                role = user.CustomerRole;
            }

            if (Session["User"] != null && role.Equals("Admin"))
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
            string id = btn.CommandArgument;
            Response.Redirect("~/view/artist/UpdateArtist.aspx?id=" + id);
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string id = btn.CommandArgument;
            ArtistController.RemoveArtistByID(Convert.ToInt32(id));
            Response.Redirect("~/view/home/Home.aspx");
        }

        protected void artistCard_Click(object sender, EventArgs e)
        {
            LinkButton card = (LinkButton)sender;
            string id = card.CommandArgument;
            Response.Redirect("~/view/artist/ArtistDetail.aspx?id=" + id);
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