using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_LAB.ado_model;
using WebService_LAB.handler;

namespace WebService_LAB.controller
{
    public class TransactionHeaderController
    {
        public static void createTransactionHeader(int customerID, DateTime transactionDate)
        {
            TransactionHeaderHandler.createTransactionHeader(customerID, transactionDate);
        }

        public static List<TransactionHeader> getAllCustomerTransactionHistory(int customerID)
        {
            return TransactionHeaderHandler.getAllCustomerTransactionHistory(customerID);
        }

    }
}