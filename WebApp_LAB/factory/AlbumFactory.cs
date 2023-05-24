using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_LAB.ado_model;

namespace WebApp_LAB.factory
{
    public class AlbumFactory
    {
        public static Album InsertNewAlbum(string name, int artistId, string description, int price, int stock, string image)
        {
            Album newAlbum = new Album
            {
                AlbumName = name,
                ArtistID = artistId,
                AlbumDescription = description,
                AlbumPrice = price,
                AlbumStock = stock,
                AlbumImage = image
            };

            return newAlbum;
        }

    }
}