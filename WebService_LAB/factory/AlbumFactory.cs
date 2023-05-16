using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_LAB.ado_model;

namespace WebService_LAB.factory
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
                AlbumImage = image
            };

            return newAlbum;
        }

    }
}