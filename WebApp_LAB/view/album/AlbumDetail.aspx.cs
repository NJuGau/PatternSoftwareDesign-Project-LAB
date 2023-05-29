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
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            Album a = AlbumController.GetAlbumByID(id);
            nameTxt.Text = a.AlbumName;
            descTxt.Text = a.AlbumDescription;
            priceTxt.Text = Convert.ToInt32(a.AlbumPrice).ToString();
            stockTxt.Text = Convert.ToInt32(a.AlbumStock).ToString();

            string role = "";
            if (Request.Cookies["user_cookie"] != null)
            {
                int userID = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                Customer user = CustomerController.getCustomerProfile(userID);
                Session["User"] = user;
                role = user.CustomerRole;
            }
            if ((Session["User"] == null) || (Session["User"] != null && role.Equals("Admin")))
            {
                qtyLbl.Visible = false;
                qtyTxt.Visible = false;
                cartBtn.Visible = false;
            }
        }

        protected void cartBtn_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            Album a = AlbumController.GetAlbumByID(id);
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
                CartController.AddNewCart(userID, id, qty);
            }
        }
    }
}