using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_LAB.ado_model;
using WebService_LAB.repository;
namespace WebService_LAB.handler
{
    public class CartHandler
    {
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