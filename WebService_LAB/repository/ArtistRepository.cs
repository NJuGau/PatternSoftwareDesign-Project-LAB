using System;
using System.Collections.Generic;
using System.Linq;
using WebService_LAB.ado_model;
using WebService_LAB.factory;

public class ArtistRepository
{
    public static List<Artist> GetAllArtist()
    {
            WebServiceDatabaseEntities db = new WebServiceDatabaseEntities();
            List<Artist> artists = (from a in db.Artists select a).ToList();
            return artists;
    }

    public static Boolean AddNewArtist (String name, String image)
    {
        WebServiceDatabaseEntities db = new WebServiceDatabaseEntities();
        Artist artist = ArtistFactory.AddNewArtist(name, image);
        db.Artists.Add(artist);
        db.SaveChanges();
        return true;
    }

    public static Boolean UpdateArtist(int id, String name,String image)
    {
        WebServiceDatabaseEntities db = new WebServiceDatabaseEntities();
        Artist artist = db.Artists.Find(id);
        artist.ArtistName = name;
        artist.ArtistImage = image;
        db.SaveChanges();
        return true;
    }

    public static Artist GetArtistByID(int id)
    {
        WebServiceDatabaseEntities db = new WebServiceDatabaseEntities();
        Artist artist = db.Artists.Find(id);
        return artist;
    }

    public static Boolean RemoveArtistByID(int id)
    {
        WebServiceDatabaseEntities db = new WebServiceDatabaseEntities();
        Artist artist = db.Artists.Find(id);
        db.Artists.Remove(artist);
        return true;
    }
}