using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_LAB.ado_model;
using WebApp_LAB.factory;

namespace WebApp_LAB.repository
{
    public class TransactionHeaderRepository
    {
        private static LocalDatabaseEntities db = DatabaseSingleton.getInstance();

        public static void addTransactionHeader(int customerID, DateTime transactionDate)
        {
            TransactionHeader newTran = TransactionHeaderFactory.createTransactionHeader(customerID, transactionDate);

            db.TransactionHeaders.Add(newTran);
            db.SaveChanges();
        }

        public static List<TransactionHeader> getCustomerHeader(int customerID)
        {
            return (from tr in db.TransactionHeaders
                    where tr.CustomerID == customerID select tr).ToList();
        }
    }
}