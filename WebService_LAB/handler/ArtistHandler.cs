using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_LAB.ado_model;
namespace WebService_LAB.handler
{
    public class ArtistHandler
    {
        public static List<Artist> GetAllArtist()
        {
            return ArtistRepository.GetAllArtist();
        }

        public static Boolean AddNewArtist(String name, String image)
        {
            return ArtistRepository.AddNewArtist(name, image);
        }
    }
}