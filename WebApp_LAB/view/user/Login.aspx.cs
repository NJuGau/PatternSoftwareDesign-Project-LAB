using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_LAB.view.user
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text;
            string pass = passTxt.Text;
            bool rememeber = rememberCheck.Checked;
            Response.Redirect("../home/Home.aspx");
        }
    }
}