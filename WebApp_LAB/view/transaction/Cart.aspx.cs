using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_LAB.ado_model;
using WebApp_LAB.controller;

namespace WebApp_LAB.view.transaction
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int userId;
            if (Request.Cookies["user_cookie"] != null)
            {
                userId = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                Customer user = CustomerController.getCustomerProfile(userId);
                Session["User"] = user;
            }

            //cartGrid.DataSource = CartController.GetAllCarts();
            //cartGrid.DataBind();

        }

        protected void checkOutBtn_Click(object sender, EventArgs e)
        {

        }
    }
}