using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_LAB.ado_model;
using WebApp_LAB.controller;

namespace WebApp_LAB.view.artist
{
    public partial class UpdateArtist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["Id"]);
                Artist a = ArtistController.GetArtistByID(id);
                nameTxt.Text = a.ArtistName;
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            string artistName = nameTxt.Text;
            string fileName = "";

            nameError.Text = ArtistController.checkArtistName(artistName);

            int artistID = Convert.ToInt32(Request.QueryString["Id"]);
            Artist a = ArtistController.GetArtistByID(artistID);

            if (artistImg.HasFile)
            {
                fileName = artistImg.PostedFile.FileName;
                string extension = Path.GetExtension(fileName);
                int fileSize = artistImg.PostedFile.ContentLength;
                imageError.Text = ArtistController.checkartisImg(extension, fileSize);
            }
            else
            {
                fileName = a.ArtistImage;
            }

            if (nameError.Text.Equals("") && imageError.Text.Equals(""))
            {
                if (artistImg.HasFile)
                {
                    string path = Server.MapPath("~/assets/artists/" + ArtistController.GetArtistByID(artistID).ArtistImage);
                    FileInfo file = new FileInfo(path);
                    if (file.Exists)
                    {
                        file.Delete();
                    }
                    artistImg.SaveAs(Server.MapPath("~/assets/artists/") + fileName);
                }

                ArtistController.UpdateArtist(artistID, artistName, fileName);
                Response.Redirect("~/view/home/Home.aspx");
            }
        }
    }
}