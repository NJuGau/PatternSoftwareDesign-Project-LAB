using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_LAB.handler;
using WebApp_LAB.ado_model;

namespace WebApp_LAB.controller
{
    public class AlbumController
    {
        public static string checkAlbumName(string name)
        {
            if (name.Equals(""))
            {
                return "Album name must be filled!";
            }
            else if (name.Length >= 50)
            {
                return "Album name must be less than 50 characters!";
            }
            return "";
        }

        public static string checkAlbumDescription(string description)
        {
            if (description.Equals(""))
            {
                return "Album description must be filled!";
            }
            else if (description.Length >= 255)
            {
                return "Album description must be less than 255 characters!";
            }
            return "";
        }

        public static string checkAlbumPrice(int price)
        {
            if (price == 0)
            {
                return "Album price must be filled!";
            }
            else if (price < 100000 || price > 1000000)
            {
                return "Album price must be between 100000 and 1000000!";
            }
            return "";
        }

        public static string checkAlbumStock(int stock)
        {
            if (stock == 0)
            {
                return "Album stock must be filled!";
            }
            else if (stock <= 0)
            {
                return "Album stock must be more than 0!";
            }
            return "";
        }

        public static string checkAlbumImageName(string ext, int size)
        {
            ext = ext.ToLower();
            String[] allowedExtension = { ".jpg", ".png", ".jfif", ".jpeg" };

            if (!allowedExtension.Contains(ext))
            {
                return "File must be in .jpg, .png, .jfif, or .jpeg format";
            }
            else if (size > 2 * 1024 * 1024)
            {
                return "File must have maximum size of 2MB";
            }
            return "";
        }

        public static void InsertNewAlbum(string name, int artistId, string description, int price, int stock, string image)
        {
             Artist findArtist = ArtistController.GetArtistByID(artistId);
             AlbumHandler.InsertNewAlbum(name, artistId, description, price, stock, image);
        }

        public static Album GetAlbumByID(int id)
        {
            return AlbumHandler.GetAlbumByID(id);
        }

        public static List<Album> GetAllAlbums()
        {
            return AlbumHandler.GetAllAlbums();
        }

        public static void UpdateAlbumByID(int albumId, string name, int artistId, string description, int price, int stock, string image)
        {
            AlbumHandler.UpdateAlbumByID(albumId, name, artistId, description, price, stock, image);
        }

        public static void RemoveAlbumByID(int id)
        {
            AlbumHandler.RemoveAlbumByID(id);
        }

        public static List<Album> getAlbumByArtistID(int artistID)
        {
            return AlbumHandler.getAlbumByArtistID(artistID);
        }
    }
}