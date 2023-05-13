using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_LAB.view.artist
{
    public partial class UpdateArtist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            int size = artistImg.PostedFile.ContentLength;
            if (size > 2000000)
            {
                errorImg.Text = "File size must be lower than 2 MB";
            }
            else
            {
                errorImg.Text = "success";
            }
        }
    }
}