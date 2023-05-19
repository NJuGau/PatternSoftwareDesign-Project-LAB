using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_LAB.controller;

namespace WebApp_LAB.view.artist
{
    public partial class UpdateArtist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            string artistName = nameTxt.Text;
            string fileName = "";
            //TODO: Get artistID
            int artistID = 0;

            nameError.Text = ArtistController.checkArtistName(artistName);

            if (artistImg.HasFile)
            {
                fileName = artistImg.PostedFile.FileName;
                string extension = Path.GetExtension(fileName);
                int fileSize = artistImg.PostedFile.ContentLength;
                imageError.Text = ArtistController.checkartisImg(extension, fileSize);
            }
            else
            {
                imageError.Text = "File is not chosen!";
            }

            if (nameError.Text.Equals("") && imageError.Text.Equals(""))
            {
                //TODO: Save image
                ArtistController.UpdateArtist(artistID, artistName, fileName);
            }
        }
    }
}