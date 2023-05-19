using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_LAB.ado_model;
using WebApp_LAB.controller;

namespace WebApp_LAB.view.artist
{
    public partial class ArtistDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TODO: Get ArtistID
            int artistID = 0;
            //List<Album> albumList = AlbumController.getAlbumByArtistID();
            //TODO: Connect albumList to GridView

        }
    }
}