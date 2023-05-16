using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_LAB.ado_model;
using WebService_LAB.factory;

namespace WebService_LAB.repository
{
    public class TransactionDetailRepository
    {
        private static WebServiceDatabaseEntities db = DatabaseSingleton.getInstance();
        public static void createTransactionDetail(int transactionID, int albumID, int qty)
        {
            TransactionDetail newDet = TransactionDetailFactory.createTransactionDetail(transactionID, albumID, qty);
            db.TransactionDetails.Add(newDet);
            db.SaveChanges();
        }

        public static List<TransactionDetail> getDetail(int transactionID)
        {
            return (from dt in db.TransactionDetails
                    where dt.TransactionID == transactionID
                    select dt).ToList();
        }
    }
}