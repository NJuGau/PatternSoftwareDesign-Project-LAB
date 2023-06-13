using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_LAB.ado_model;
using WebApp_LAB.repository;

namespace WebApp_LAB.handler
{
    public class CartHandler
    {
        public static void AddNewCart(int customerId, int albumId, int quantity)
        {
            CartRepository.AddNewCart(customerId, albumId, quantity);
        }
        public static dynamic GetAllCartsPage(int customerId)
        {
            return CartRepository.GetAllCartsPage(customerId);
        }

        public static dynamic GetCartById(int customerId, int albumId)
        {
            return CartRepository.GetCartById(customerId, albumId);
        }
        public static void AddQuantity(int customerId, int albumId, int quantity)
        {
            CartRepository.AddQuantity(customerId, albumId, quantity);
        }
        public static void RemoveCartById(int customerId, int albumId)
        {
            CartRepository.RemoveCartById(customerId, albumId);
        }

        public static List<Cart> getAllJustCarts(int customerId)
        {
            return CartRepository.GetAllJustCarts(customerId);
        }

        public static void CheckOutCart(int userId)
        {
            // CartRepository.CheckOutCart(userId);

            List<Cart> carts = CartRepository.GetAllJustCarts(userId);

            if (carts.Count == 0)
            {
                return;
            }

            int transactionID = TransactionHeaderRepository.addTransactionHeader(userId, DateTime.Now);

            foreach (Cart c in carts)
            {
                int qty = c.Qty;

                Album album = AlbumRepository.GetAlbumByID(c.AlbumID);
                AlbumRepository.UpdateAlbumByID(album.AlbumID, album.AlbumName, album.ArtistID, album.AlbumDescription, album.AlbumPrice, album.AlbumStock - qty, album.AlbumImage);

                TransactionDetailRepository.addTransactionDetail(transactionID, c.AlbumID, qty);
            }

            CartRepository.RemoveAllCartsById(userId);
        }
    }
}