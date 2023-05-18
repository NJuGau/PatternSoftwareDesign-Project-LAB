using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_LAB.ado_model;

namespace WebApp_LAB.factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader createTransactionHeader(int customerID, DateTime transactionDate)
        {
            return new TransactionHeader()
            {
                CustomerID = customerID,
                TransactionDate = transactionDate
            };
        }
    }
}