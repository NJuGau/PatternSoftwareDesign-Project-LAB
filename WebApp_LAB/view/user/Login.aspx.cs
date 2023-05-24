using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_LAB.ado_model;
using WebApp_LAB.controller;

namespace WebApp_LAB.view.user
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["customer_id"] != null && Session["customer"] == null)
            {
                int iD = Convert.ToInt32(Request.Cookies["customer_id"].Value);
                Customer c = CustomerController.getCustomerProfile(iD);
                Session["customer"] = c;
                Response.Redirect("~/view/user/UpdateProfile.aspx");
            }
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text;
            string pass = passTxt.Text;
            bool rememeber = rememberCheck.Checked;
            Console.WriteLine(rememeber);

            Customer c = CustomerController.login(email, pass);
            if (c != null)
            {

                if (rememeber == true)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = c.CustomerID.ToString();
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }

                Session["User"] = c;
                Response.Redirect("~/view/home/Home.aspx");
            }
            else
            {
                loginError.Text = "Invalid Username or Password!";
            }
        }
    }
}