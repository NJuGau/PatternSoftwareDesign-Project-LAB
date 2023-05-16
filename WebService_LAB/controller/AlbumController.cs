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
                WebServiceDatabaseEntities db = new WebServiceDatabaseEntities();
                Artist findArtist = db.Artists.Find(artistId);
                if (findArtist == null) return false;
                else return AlbumHandler.InsertNewAlbum(name, artistId, description, price, stock, image);
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

        public static List<Album> GetAllAlbums()
        {
            return AlbumHandler.GetAllAlbums();
        }

        public static bool UpdateAlbumByID(int albumId, string name, int artistId, string description, int price, int stock, string image)
        {
            if (name.Length < 50 && description.Length < 255 && (price >= 100000 && price <= 1000000) && stock > 0 && image.Length > 0)
            {
                WebServiceDatabaseEntities db = new WebServiceDatabaseEntities();
                Artist findArtist = db.Artists.Find(artistId);
                if (findArtist == null) return false;
                else return AlbumHandler.UpdateAlbumByID(albumId,name, artistId, description, price, stock, image);
            }
            return false;
        }

        public static bool RemoveAlbumByID(int id)
        {
            WebServiceDatabaseEntities db = new WebServiceDatabaseEntities();
            Album findAlbum = db.Albums.Find(id);
            return findAlbum != null && AlbumHandler.RemoveAlbumByID(id);
        }
    }
}