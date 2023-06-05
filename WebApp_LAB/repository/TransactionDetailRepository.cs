using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_LAB.ado_model;
using WebApp_LAB.factory;

namespace WebApp_LAB.repository
{
    public class TransactionDetailRepository
    {
        private static LocalDatabaseEntities db = DatabaseSingleton.getInstance();
        public static void addTransactionDetail(int transactionID, int albumID, int qty)
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