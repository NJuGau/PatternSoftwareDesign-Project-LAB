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
        public static List<Cart> GetAllCarts()
        {
            return CartHandler.GetAllCarts();
        }
        public static bool CheckOutCart()
        {
            return CartHandler.CheckOutCart();
        }
        public static bool AddNewCart(int customerId, int albumId, int quantity)
        {
            return CartHandler.AddNewCart(customerId, albumId, quantity);
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