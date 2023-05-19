using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_LAB.controller;

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
            string gender ="";
            string address = addressTxt.Text;
            string pass = passTxt.Text;
            
            if (maleRadio.Checked)
            {
                gender = "Male";
            }
            else if(femaleRadio.Checked)
            {
                gender = "Female";
            }

            nameError.Text = CustomerController.checkName(name);
            emailError.Text = CustomerController.checkEmail(email);
            genderError.Text = CustomerController.checkGender(gender);
            addressError.Text = CustomerController.checkAddress(address);
            passError.Text = CustomerController.checkPassword(pass);

            if(nameError.Text.Equals("") && emailError.Text.Equals("") && genderError.Text.Equals("") && addressError.Text.Equals("") && passError.Text.Equals(""))
            {
                CustomerController.register(name, email, gender, address, pass);
                Response.Redirect("~/view/user/Login.aspx");
            }
        }
    }
}