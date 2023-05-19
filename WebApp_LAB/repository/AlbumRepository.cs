﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_LAB.factory;
using WebApp_LAB.ado_model;

namespace WebApp_LAB.repository
{
    public class AlbumRepository
    {
        private static LocalDatabaseEntities db = DatabaseSingleton.getInstance();
        public static bool InsertNewAlbum(string name, int artistId, string description, int price, int stock, string image)
        {
            Album newAlbum = AlbumFactory.InsertNewAlbum(name, artistId, description, price, stock, image);
            db.Albums.Add(newAlbum);
            db.SaveChanges();
            return true;
        }

        public static Album GetAlbumByID(int id)
        {
            Album album = db.Albums.Find(id);
            return album;
        }

        public static List<Album> GetAllAlbums()
        {
            List<Album> albums = (from a in db.Albums select a).ToList();
            return albums;
        }

        public static bool UpdateAlbumByID(int albumId,string name, int artistId, string description, int price, int stock, string image)
        {
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

        public static bool RemoveAlbumByID(int id)
        {
            Album album = db.Albums.Find(id);
            db.Albums.Remove(album);
            return true;
        }

    }
}