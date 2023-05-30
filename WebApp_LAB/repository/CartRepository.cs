﻿using System;
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

        public static dynamic GetAllCarts(int customerId)
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

        public static void RemoveCartById(int customerId, int albumId)
        {
            Cart cart = db.Carts.FirstOrDefault(c => c.CustomerID == customerId && c.AlbumID == albumId);
            db.Carts.Remove(cart);
            db.SaveChanges();
        }

        public static void CheckOutCart()
        {
            List<Cart> carts = (from a in db.Carts select a).ToList();
            db.Carts.RemoveRange(carts);
            db.SaveChanges();
        }

        public static void RemoveStocks(int albumId, int quantity)
        {

        }
    }
}