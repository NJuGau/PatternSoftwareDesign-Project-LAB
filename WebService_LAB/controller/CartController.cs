using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_LAB.ado_model;
using WebService_LAB.handler;

namespace WebService_LAB.controller
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
    }
}