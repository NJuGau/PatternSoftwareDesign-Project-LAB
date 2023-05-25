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

        public static string validateArtistName(string name, string currentName)
        {
            if (name.Equals(""))
            {
                return "Artist name must be filled!";
            }
            else if (!NameExistValidation(name) && name.Equals(currentName) == false)
            {
                return "Artist name must be unique!";
            }
            return "";
        }

        public static string checkartisImg(string ext, int size)
        {
            ext = ext.ToLower();
            String[] allowedExtension = { ".jpg", ".png", ".jfif", ".jpeg" };

            if (!allowedExtension.Contains(ext))
            {
                return "File must be in .jpg, .png, .jfif, or .jpeg format";
            }
            else if (size > 2 * 1024 *1024)
            {
                return "File must have maximum size of 2MB";
            }
            return "";
        }

        public static void AddNewArtist(String name,String image)
        {
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
            ArtistHandler.RemoveArtistByID(id);
        }
    }
}