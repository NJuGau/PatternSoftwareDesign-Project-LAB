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
}