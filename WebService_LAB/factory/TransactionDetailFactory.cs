﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_LAB.ado_model;

namespace WebService_LAB.factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail createTransactionDetail(int transactionID, int albumID, int qty)
        {
            return new TransactionDetail()
            {
                TransactionID = transactionID,
                AlbumID = albumID,
                Qty = qty
            };
        }
    }
}