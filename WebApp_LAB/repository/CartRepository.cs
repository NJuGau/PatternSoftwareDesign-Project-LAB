using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_LAB.ado_model;
using WebApp_LAB.factory;

namespace WebApp_LAB.repository
{
    public class CartRepository
    {
        private static LocalDatabaseEntities db = new LocalDatabaseEntities();

        public static void AddNewCart(int customerId, int albumId, int quantity)
        {
            Cart newCart = CartFactory.CreateNewCart(customerId, albumId, quantity);
            db.Carts.Add(newCart);
            db.SaveChanges();
        }

        public static dynamic GetAllCartsPage(int customerId)
        {
            return db.Carts.Join(db.Albums, cart => cart.AlbumID, album => album.AlbumID, (cart, album) => new
            {
                CustomerID = cart.CustomerID,
                AlbumID = cart.AlbumID,
                AlbumName = album.AlbumName,
                AlbumImage = album.AlbumImage,
                AlbumPrice = album.AlbumPrice,
                Quantity = cart.Qty,
            }).Where(c => c.CustomerID == customerId).ToList();
        }

        public static List<Cart> GetAllJustCarts(int customerId)
        {
            return db.Carts.Where(c => c.CustomerID == customerId).ToList();
        }

        public static Cart GetCartById(int customerId, int albumId)
        {
            return db.Carts.FirstOrDefault(c => c.CustomerID == customerId && c.AlbumID == albumId);
        }

        public static void AddQuantity(int customerId, int albumId, int quantity)
        {
            Cart cart = CartRepository.GetCartById(customerId, albumId);
            cart.Qty = cart.Qty + quantity;
            db.SaveChanges();
        }

        public static void RemoveCartById(int customerId, int albumId)
        {
            Cart cart = db.Carts.FirstOrDefault(c => c.CustomerID == customerId && c.AlbumID == albumId);
            db.Carts.Remove(cart);
            db.SaveChanges();
        }

        public static void RemoveAllCartsById(int userId)
        {
            List<Cart> carts = CartRepository.GetAllJustCarts(userId);
            db.Carts.RemoveRange(carts);
            db.SaveChanges();
        }

        //public static void CheckOutCart(int userId)
        //{
        //    // Remove all items from carts
        //    List<Cart> carts = (from a in db.Carts where a.CustomerID == userId select a).ToList();

        //    if (carts.Count == 0)
        //    {
        //        return;
        //    }

        //    TransactionHeaderRepository.addTransactionHeader(userId, DateTime.Now);
        //    db.SaveChanges();
            

        //    foreach (Cart c in carts)
        //    {
        //        Album album = AlbumRepository.GetAlbumByID(c.AlbumID);
        //        album.AlbumStock -= c.Qty;
        //        db.SaveChanges();
        //    }
        //    db.Carts.RemoveRange(carts);
        //    db.SaveChanges();
        //}
    }
}