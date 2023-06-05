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

        public static int addTransactionHeader(int customerID, DateTime transactionDate)
        {
            TransactionHeader newTran = TransactionHeaderFactory.createTransactionHeader(customerID, transactionDate);

            db.TransactionHeaders.Add(newTran);
            db.SaveChanges();

            return newTran.TransactionID;
        }

        public static List<TransactionHeader> getCustomerHeader(int customerID)
        {
            return (from tr in db.TransactionHeaders
                    where tr.CustomerID == customerID select tr).ToList();
        }

        public static dynamic getTransactionHistory(int customerID)
        {
            Customer customer = db.Customers.Where(c => c.CustomerID == customerID).FirstOrDefault();

            return db.TransactionHeaders.Join(db.TransactionDetails, th => th.TransactionID, td => td.TransactionID, (th, td) => new
            { th, td }).Join(db.Albums, t => t.td.AlbumID, album => album.AlbumID, (t, album) => new
            {
                TransactionID = t.th.TransactionID,
                TransactionDate = t.th.TransactionDate,
                CustomerID = t.th.CustomerID,
                CustomerName = customer.CustomerName,
                AlbumImage = album.AlbumImage,
                AlbumName = album.AlbumName,
                Quantity = t.td.Qty,
                AlbumPrice = album.AlbumPrice,
            }).Where(c => c.CustomerID == customerID).ToList();
        }
    }
}