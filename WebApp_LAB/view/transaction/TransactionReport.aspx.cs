using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WebApp_LAB.Reporting;
using WebApp_LAB.ado_model;
using WebApp_LAB.controller;

namespace WebApp_LAB.view.transaction
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null && !((Customer)Session["User"]).CustomerRole.Equals("Admin"))
            {
                Response.Redirect("~/view/home/Home.aspx");
                return;
            }

            if (!IsPostBack)
            {

                CrystalReport2 report = new CrystalReport2();
                CrystalReportViewer1.ReportSource = report;

                DataSet1 data = refreshData(TransactionHeaderController.getAllTransactionHeaders());
                report.SetDataSource(data);

            }
        }

        private DataSet1 refreshData(List<TransactionHeader> transactions)
        {
            DataSet1 newData = new DataSet1();
            var headerTable = newData.TransactionHeader;
            var detailTable = newData.TransactionDetail;

            foreach (TransactionHeader th in transactions)
            {
                var row = headerTable.NewRow();
                row["TransactionID"] = th.TransactionID;
                row["CustomerID"] = th.CustomerID;
                row["TransactionDate"] = th.TransactionDate;

                int grandTotal = 0;

                foreach (TransactionDetail td in TransactionDetailController.getDetail(th.TransactionID))
                {
                    var drow = detailTable.NewRow();
                    drow["TransactionID"] = th.TransactionID;
                    drow["AlbumID"] = td.AlbumID;
                    drow["Qty"] = td.Qty;
                    drow["Price"] = td.Album.AlbumPrice;

                    int subTotal = td.Qty * td.Album.AlbumPrice;
                    drow["SubTotal"] = subTotal;
                    grandTotal += subTotal;

                    detailTable.Rows.Add(drow);
                }

                row["GrandTotal"] = grandTotal;
                headerTable.Rows.Add(row);
            }

            return newData;
        }
    }
}