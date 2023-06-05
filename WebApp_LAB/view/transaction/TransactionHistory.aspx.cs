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
    public partial class TransactionHistory : System.Web.UI.Page
    {
        int userID;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                userID = ((Customer)Session["User"]).CustomerID;

                transactionHistoryGrid.DataSource = TransactionHeaderController.getAllCustomerTransactionHistory(userID);
                transactionHistoryGrid.DataBind();

            }
        }

        protected void transactionHistoryGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}