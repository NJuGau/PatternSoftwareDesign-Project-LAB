using System;
using System.Collections.Generic;
using System.Linq;
using WebApp_LAB.ado_model;
using WebApp_LAB.factory;

namespace WebApp_LAB.repository
{ 
    public class ArtistRepository
    {
        private static LocalDatabaseEntities db = DatabaseSingleton.getInstance();
        public static List<Artist> GetAllArtist()
        {
            return db.Artists.ToList();
        }

        public static void AddNewArtist (String name, String image)
        {
            Artist artist = ArtistFactory.AddNewArtist(name, image);
            db.Artists.Add(artist);
            db.SaveChanges();
        }

        public static Boolean UpdateArtist(int id, String name,String image)
        {
            Artist artist = db.Artists.Find(id);
            artist.ArtistName = name;
            artist.ArtistImage = image;
            db.SaveChanges();
            return true;
        }

        public static Artist GetArtistByID(int id)
        {
            Artist artist = db.Artists.Find(id);
            return artist;
        }

        public static void RemoveArtistByID(int id)
        {
            Artist artist = db.Artists.Find(id);
            db.Artists.Remove(artist);
            db.SaveChanges();
        }
    }
}