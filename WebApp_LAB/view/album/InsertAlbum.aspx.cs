using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_LAB.controller;

namespace WebApp_LAB.view.album
{
    public partial class InsertAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            int artistId = Convert.ToInt32(Request.QueryString["id"]);
            string name = nameTxt.Text;
            string desc = descTxt.Text;
            int price = 0;
            int stock = 0;
            try
            {
                price = Convert.ToInt32(priceTxt.Text);
            }
            catch
            {
                price = 0;
            }
            try
            {
                stock = Convert.ToInt32(stockTxt.Text);
            }
            catch
            {
                stock = 0;
            }
            string fileName = "";

            nameError.Text = AlbumController.checkAlbumName(name);
            descError.Text = AlbumController.checkAlbumDescription(desc);
            priceError.Text = AlbumController.checkAlbumPrice(price);
            stockError.Text = AlbumController.checkAlbumStock(stock);

            if (albumImg.HasFile)
            {
                fileName = albumImg.PostedFile.FileName;
                string extension = Path.GetExtension(fileName);
                int fileSize = albumImg.PostedFile.ContentLength;
                imageError.Text = AlbumController.checkAlbumImageName(extension, fileSize);
            }
            else
            {
                imageError.Text = "File is not chosen!";
            }

            if (nameError.Text.Equals("") && descError.Text.Equals("") && priceError.Text.Equals("") && stockError.Text.Equals("") && imageError.Text.Equals(""))
            {
                albumImg.SaveAs(Server.MapPath("~/assets/albums/") + fileName);
                AlbumController.InsertNewAlbum(name, artistId, desc, price, stock, fileName);
            }
        }
    }
}