using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_LAB.ado_model;
using WebApp_LAB.repository;

namespace WebApp_LAB.handler
{
    public class ArtistHandler
    {
        public static List<Artist> GetAllArtist()
        {
            return ArtistRepository.GetAllArtist();
        }

        public static void AddNewArtist(String name, String image)
        {
            ArtistRepository.AddNewArtist(name, image);
        }

        public static Boolean UpdateArtist(int id, String name, String image)
        {
            return ArtistRepository.UpdateArtist(id,name, image);
        }

        public static Artist GetArtistByID(int id)
        {
            return ArtistRepository.GetArtistByID(id);
        }

        public static void RemoveArtistByID(int id)
        {
            ArtistRepository.RemoveArtistByID(id);
        }
    }
}