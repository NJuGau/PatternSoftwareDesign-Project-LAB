using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_LAB.view.user
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string email = emailTxt.Text;
            string gender;
            string address = addressTxt.Text;
            string pass = passTxt.Text;

            int nameLen = name.Length;
            if (maleRadio.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
        }
    }
}