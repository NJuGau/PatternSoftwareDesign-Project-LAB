using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_LAB.ado_model;
using WebService_LAB.repository;

namespace WebService_LAB.handler
{
    public class TransactionHeaderHandler
    {
        public static void createTransactionHeader(int customerID, DateTime transactionDate)
        {
            TransactionHeaderRepository.addTransactionHeader(customerID, transactionDate);
        }

        public static List<TransactionHeader> getAllCustomerTransactionHistory(int customerID)
        {
            return TransactionHeaderRepository.getCustomerHeader(customerID);
        }
    }
}