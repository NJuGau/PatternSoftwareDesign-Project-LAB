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
        public static dynamic GetAllCarts(int customerId)
        {
            return CartRepository.GetAllCarts(customerId);
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
        public static void CheckOutCart(int userId)
        {
            CartRepository.CheckOutCart(userId);
        }
    }
}