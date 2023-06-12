using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_LAB.ado_model;
using WebApp_LAB.controller;

namespace WebApp_LAB.view.master
{
    public partial class MainPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["User"] == null)
            {
                loginLink.Visible = true;
                registerLink.Visible = true;
                cartBtn.Visible = false;
                transactionHistoryLink.Visible = false;
                updateLink.Visible = false;
                logoutBtn.Visible = false;
                transactionReportLink.Visible = false;
            }
            else if(Session["User"] != null && ((Customer)Session["User"]).CustomerRole.Equals("Admin"))
            {
                cartBtn.Visible = false;
                transactionReportLink.Visible = true;
                transactionHistoryLink.Visible = false;
            }
            else
            {
                // Not admin
                transactionReportLink.Visible = false;
            }
        }

        protected void cartBtn_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(((Customer)Session["User"]).CustomerID);
            Response.Redirect("~/view/transaction/Cart.aspx?userId=" + userId);
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                HttpContext.Current.Session.Remove("User");
            }
            string[] cookies = HttpContext.Current.Request.Cookies.AllKeys;
            foreach (string cookie in cookies)
            {
                HttpContext.Current.Response.Cookies[cookie].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Redirect("~/view/user/Login.aspx");
        }
    }
}