using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_LAB.ado_model;
using WebApp_LAB.controller;

namespace WebApp_LAB.view.album
{
    public partial class AlbumDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int albumId = Convert.ToInt32(Request.QueryString["albumId"]);
            Album a = AlbumController.GetAlbumByID(albumId);
            nameTxt.Text = a.AlbumName;
            descTxt.Text = a.AlbumDescription;
            priceTxt.Text = Convert.ToInt32(a.AlbumPrice).ToString();
            stockTxt.Text = Convert.ToInt32(a.AlbumStock).ToString();

            if ((Session["User"] == null) || (Session["User"] != null && ((Customer)Session["User"]).CustomerRole.Equals("Admin")))
            {
                qtyLbl.Visible = false;
                qtyTxt.Visible = false;
                cartBtn.Visible = false;
            }
        }

        protected void cartBtn_Click(object sender, EventArgs e)
        {
            int userID = ((Customer)Session["User"]).CustomerID;
            int albumId = Convert.ToInt32(Request.QueryString["albumId"]);
            Album a = AlbumController.GetAlbumByID(albumId);
            int qty = 0;
            try
            {
                qty = Convert.ToInt32(qtyTxt.Text);
            }
            catch
            {
                qty = 0;
            }

            qtyError.Text = CartController.checkStock(qty, a);

            if (qtyError.Text.Equals(""))
            {
                CartController.AddNewCart(userID, albumId, qty);
                Response.Redirect("~/view/transaction/Cart.aspx?userId="+ userID);
            }
        }
    }
}