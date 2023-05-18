using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_LAB.ado_model;
using WebApp_LAB.handler;

namespace WebApp_LAB.controller
{
    public class TransactionDetailController
    {
        public static void createTransactionDetail(int transactionID, int albumID, int qty)
        {
            TransactionDetailHandler.createTransactionDetail(transactionID, albumID, qty);
        }

        public static List<TransactionDetail> getDetail(int transactionID)
        {
            return TransactionDetailHandler.getDetail(transactionID);
        }
    }
}