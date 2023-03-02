using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_LAB.factory;
using WebService_LAB.ado_model;

namespace WebService_LAB.repository
{
    public class AlbumRepository
    {
        public static bool InsertNewAlbum(string name, int artistId, string description, int price, int stock, string image)
        {
            WebServiceDatabaseEntities db = new WebServiceDatabaseEntities();
            Album newAlbum = AlbumFactory.InsertNewAlbum(name, artistId, description, price, stock, image);
            db.Albums.Add(newAlbum);
            db.SaveChanges();
            return true;
        }

        public static Album GetAlbumByID(int id)
        {
            WebServiceDatabaseEntities db = new WebServiceDatabaseEntities();
            Album album = db.Albums.Find(id);
            return album;
        }

        public static List<Album> GetAllAlbums()
        {
            WebServiceDatabaseEntities db = new WebServiceDatabaseEntities();
            List<Album> albums = (from a in db.Albums select a).ToList();
            return albums;
        }

        public static bool UpdateAlbumByID(int albumId,string name, int artistId, string description, int price, int stock, string image)
        {
            WebServiceDatabaseEntities db = new WebServiceDatabaseEntities();
            Album album = db.Albums.Find(albumId);
            album.AlbumName = name;
            album.AlbumDescription = description;
            album.ArtistID = artistId;
            album.AlbumPrice = price;
            album.AlbumStock = stock;
            album.AlbumImage = image;
            db.SaveChanges();
            return true;
        }

    }
}