using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_LAB.ado_model;
using WebService_LAB.handler;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Services;

namespace WebService_LAB.controller
{
    public class ArtistController
    {
        public static List<Artist> GetAllArtist()
        {
            return ArtistHandler.GetAllArtist();
        }

        private static Boolean NameExistValidation(string name)
        {
            WebServiceDatabaseEntities db = new WebServiceDatabaseEntities();
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

        public static Boolean AddNewArtist(String name,String image)
        {
            //validate extension file dan ukuran file di frontend.
            return NameExistValidation(name) ? false : ArtistHandler.AddNewArtist(name, image);
        }

        public static Boolean UpdateArtist(int id,String name, String image)
        {
            WebServiceDatabaseEntities db = new WebServiceDatabaseEntities();
            Artist artist = db.Artists.Find(id);
            if (artist == null) return false;
            return ArtistHandler.UpdateArtist(id, name, image);
        }
    }
}