using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_LAB.ado_model;

namespace WebApp_LAB.factory
{
    public class ArtistFactory
    {
        public static Artist AddNewArtist(String name, String image)
        {
            Artist artist = new Artist
            {
                ArtistName = name,
                ArtistImage = image
            };
            return artist;
        }
    }
}