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

        public static bool AddNewCart(int customerId, int albumId, int quantity)
        {
            Cart newCart = CartFactory.CreateNewCart(customerId, albumId, quantity);
            db.Carts.Add(newCart);
            db.SaveChanges();
            return true;
        }

        public static List<Cart> GetAllCarts()
        {
            List<Cart> carts = (from a in db.Carts select a).ToList();
            return carts;
        }

        public static Cart GetCartById(int customerId, int albumId)
        {
            Cart cart = db.Carts.FirstOrDefault(c => c.CustomerID == customerId && c.AlbumID == albumId);
            return cart;
        }

        public static bool CheckOutCart()
        {
            List<Cart> carts = (from a in db.Carts select a).ToList();
            db.Carts.RemoveRange(carts);
            db.SaveChanges();
            return true;
        }
    }
}