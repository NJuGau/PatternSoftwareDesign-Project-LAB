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
        public static bool AddNewCart(int customerId, int albumId, int quantity)
        {
            return CartRepository.AddNewCart(customerId, albumId, quantity);
        }
        public static List<Cart> GetAllCarts()
        {
            return CartRepository.GetAllCarts();
        }
        public static Cart GetCartById(int customerId, int albumId)
        {
            return CartRepository.GetCartById(customerId, albumId);
        }
        public static bool CheckOutCart()
        {
            return CartRepository.CheckOutCart();
        }
    }
}