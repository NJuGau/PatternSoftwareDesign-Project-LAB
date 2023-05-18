using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_LAB.ado_model;
using WebApp_LAB.handler;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Services;

namespace WebApp_LAB.controller
{
    public class ArtistController
    {
        public static List<Artist> GetAllArtist()
        {
            return ArtistHandler.GetAllArtist();
        }

        private static Boolean NameExistValidation(string name)
        {
            List<Artist> artistslist = GetAllArtist();
            foreach (Artist a in artistslist)
            {
                if (String.Compare(a.ArtistName, name) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static string checkArtistName(string name)
        {
            if (name.Equals(""))
            {
                return "Artist name must be filled!";
            }
            else if (!NameExistValidation(name))
            {
                return "Artist name must be unique!";
            }
            return "";
        }

        public static void AddNewArtist(String name,String image)
        {
            //validate extension file dan ukuran file di frontend.
            ArtistHandler.AddNewArtist(name, image);
        }

        public static void UpdateArtist(int id,String name, String image)
        {
            Artist artist = GetArtistByID(id);
            if (artist == null) return;
            ArtistHandler.UpdateArtist(id, name, image);
        }

        public static Artist GetArtistByID(int id)
        {
            Artist artist = ArtistHandler.GetArtistByID(id);
            if (artist == null) return null;
            return ArtistHandler.GetArtistByID(id);
        }

        public static void RemoveArtistByID(int id)
        {
            Artist artist = ArtistHandler.GetArtistByID(id);
            if (artist == null) return;
            ArtistHandler.RemoveArtistByID(id);
        }
    }
}