using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_LAB.ado_model;
namespace WebApp_LAB.factory
{
    public class CartFactory
    {
        public static Cart CreateNewCart(int customerId, int albumId, int quantity)
        {
            Cart cart = new Cart
            {
                CustomerID = customerId,
                AlbumID = albumId,
                Qty = quantity
            };
            return cart;
        }
    }
}