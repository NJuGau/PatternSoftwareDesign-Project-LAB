using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_LAB.repository;
using WebService_LAB.ado_model;

namespace WebService_LAB.handler
{
    public class AlbumHandler
    {
        public static bool InsertNewAlbum(string name, int artistId, string description, int price, int stock, string image)
        {
            return AlbumRepository.InsertNewAlbum(name, artistId, description, price, stock, image);
        }

        public static Album GetAlbumByID(int id)
        {
            return AlbumRepository.GetAlbumByID(id);
        }

    }
}