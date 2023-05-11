using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_LAB.view.user
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void regisBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string email = emailTxt.Text;
            string gender;
            string address = addressTxt.Text;
            string pass = passTxt.Text;

            int nameLen = name.Length;
            //if(nameLen < 5 || nameLen > 50)
            //{
            //    nameError.Text = "Name must be between 5 - 50 characters";
            //}
            if (maleRadio.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            //if(address.EndsWith("Street") == false)
            //{
            //    addressError.Text = "Address must end with the word 'Street'";
            //}
            //if (!pass.All(char.IsLetterOrDigit))
            //{
            //    passError.Text = "Password must be alphanumeric only"
            //}

        }
    }
}