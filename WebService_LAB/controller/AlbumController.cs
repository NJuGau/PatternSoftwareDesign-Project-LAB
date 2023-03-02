using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_LAB.handler;
using WebService_LAB.ado_model;

namespace WebService_LAB.controller
{
    public class AlbumController
    {
        public static bool InsertNewAlbum(string name, int artistId, string description, int price, int stock, string image)
        {
            if(name.Length < 50 && description.Length < 255 && (price >= 100000 && price <= 1000000) && stock > 0 && image.Length > 0)
            {
                return AlbumHandler.InsertNewAlbum(name, artistId, description, price, stock, image);
            }
            return false;
        }

        public static Album GetAlbumByID(int id)
        {
            WebServiceDatabaseEntities db = new WebServiceDatabaseEntities();
            Album findAlbum = db.Albums.Find(id);
            if (findAlbum == null) return null;
            return AlbumHandler.GetAlbumByID(id);
        }
    }
}