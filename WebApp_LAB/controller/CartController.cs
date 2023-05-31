using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_LAB.ado_model;
using WebApp_LAB.handler;


namespace WebApp_LAB.controller
{
    public class CartController
    {
        public static dynamic GetAllCarts(int customerId)
        {
            return CartHandler.GetAllCarts(customerId);
        }
        public static void CheckOutCart(int userId)
        {
            CartHandler.CheckOutCart(userId);
        }
        public static void AddNewCart(int customerId, int albumId, int quantity)
        {
            if(CartHandler.GetCartById(customerId, albumId) == null)
            {
                CartHandler.AddNewCart(customerId, albumId, quantity);
            }
            else
            {
                CartHandler.AddQuantity(customerId, albumId, quantity);
            }
        }
        public static void RemoveCartById(int customerId, int albumId)
        {
            CartHandler.RemoveCartById(customerId, albumId);
        }
        public static string checkStock(int qty, Album a)
        {
            int stock = a.AlbumStock;
            if (qty <= 0)
            {
                return "Quantity must be filled!";
            }
            else if (qty > stock)
            {
                return "Stock isn't enough";
            }
            return "";
        }
    }
}