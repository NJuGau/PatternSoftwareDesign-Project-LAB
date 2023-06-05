using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_LAB.ado_model;
using WebApp_LAB.repository;

namespace WebApp_LAB.handler
{
    public class TransactionHeaderHandler
    {
        public static void createTransactionHeader(int customerID, DateTime transactionDate)
        {
            TransactionHeaderRepository.addTransactionHeader(customerID, transactionDate);
        }

        public static dynamic getAllCustomerTransactionHistory(int customerID)
        {
            return TransactionHeaderRepository.getTransactionHistory(customerID);
        }
    }
}