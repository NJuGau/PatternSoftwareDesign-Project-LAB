using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_LAB.ado_model;
using WebApp_LAB.controller;

namespace WebApp_LAB.view.transaction
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(Request.QueryString["userId"]);

            if (!IsPostBack)
            {
                cartGrid.DataSource = CartController.GetAllCartsPage(userId);
                cartGrid.DataBind();
                cartGrid.Columns[0].Visible = false;
            }

        }
        protected void checkOutBtn_Click(object sender, EventArgs e)
        {
            // For loop utk ambil tiap data dan melakukan pengurangan

            //CartController.RemoveStocks()
            int userId = Convert.ToInt32(Request.QueryString["userId"]);
            qtyErrorTxt.Text = CartController.checkIfAllQtyAvail(userId);
            if(qtyErrorTxt.Text == "")
            {
                CartController.CheckOutCart(userId);
                Response.Redirect("~/view/home/Home.aspx");
            }
        }

        protected void cartGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int userId = Convert.ToInt32(Request.QueryString["userId"]);

            cartGrid.Columns[0].Visible = true;
            GridViewRow row = cartGrid.Rows[e.RowIndex];
            String ID = row.Cells[0].Text;
            int albumId = Convert.ToInt32(ID);

            CartController.RemoveCartById(userId, albumId);
            Response.Redirect("~/view/transaction/Cart.aspx?userId=" + userId);
        }
    }
}