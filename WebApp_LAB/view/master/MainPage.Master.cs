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

            string role = "";
            if (Request.Cookies["user_cookie"] != null)
            {
                int id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                Customer user = CustomerController.getCustomerProfile(id);
                Session["User"] = user;
                role = user.CustomerRole;
            } 

            if(Session["User"] == null)
            {
                loginLink.Visible = true;
                registerLink.Visible = true;
                cartLink.Visible = false;
                transactionLink.Visible = false;
                updateLink.Visible = false;
                logoutButton.Visible = false;
            }
            else if(Session["User"] != null && role.Equals("Admin"))
            {
                cartLink.Visible = false;
            }
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            if(Session["customer"] != null)
            {
                HttpContext.Current.Session.Remove("customer");
            }
            else if(Session["admin"] != null)
            {
                HttpContext.Current.Session.Remove("admin");
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