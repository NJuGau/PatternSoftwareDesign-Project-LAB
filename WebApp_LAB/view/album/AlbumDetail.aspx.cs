using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_LAB.ado_model;
using WebApp_LAB.controller;

namespace WebApp_LAB.view.album
{
    public partial class AlbumDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            Album a = AlbumController.GetAlbumByID(id);
            nameTxt.Text = a.AlbumName;
            descTxt.Text = a.AlbumDescription;
            priceTxt.Text = Convert.ToInt32(a.AlbumPrice).ToString();
            stockTxt.Text = Convert.ToInt32(a.AlbumStock).ToString();
        }

        protected void cartBtn_Click(object sender, EventArgs e)
        {
            int qty = Convert.ToInt32(qtyTxt.Text);
        }
    }
}