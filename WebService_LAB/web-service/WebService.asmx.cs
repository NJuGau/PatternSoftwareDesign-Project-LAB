using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebService_LAB.ado_model;
using WebService_LAB.controller;
using Newtonsoft.Json;

namespace WebService_LAB.web_service
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetAllArtist()
        {
            List<Artist> artists = ArtistController.GetAllArtist();
            string json = JsonConvert.SerializeObject(artists);
            return json;
        }

        [WebMethod]
        public Boolean AddNewArtist(String name, String image)
        {
            //return string 
            //return ArtistController.AddNewArtist(name, image) == true ? "Successfully add new artist" : "Add new artist failed";

            //return boolean
            return ArtistController.AddNewArtist(name, image);
        }

        [WebMethod]
        public Boolean UpdateArtistByID(int id,String name, String image)
        {
            //return ArtistController.UpdateArtist(id, name, image) == true ? "Artist Successfully Updated" : "Artist update failed";

            return ArtistController.UpdateArtist(id, name, image);
        }

        [WebMethod]
        public string GetArtistByID(int id)
        {
            Artist artist = ArtistController.GetArtistByID(id);
            String json = JsonConvert.SerializeObject(artist, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return json;
        }

        public Boolean RemoveArtistByID(int id)
        {
            //return ArtistController.RemoveArtistByID(id) == true ? "Successfully remove artist" : "Artist remove failed";

            return ArtistController.RemoveArtistByID(id);
        }

        [WebMethod]
        public String login(String email, String password)
        {
            return CustomerController.login(email, password);
        }

        [WebMethod]
        public String register(String name, String email, String gender, String address, String password)
        {
            return CustomerController.register(name, email, gender, address, password);
        }

        [WebMethod]
        public String viewProfile(int iD)
        {
            return CustomerController.getCustomerProfile(iD);
        }

        [WebMethod]
        public String updateProfile(int iD, String name, String email, String gender, String address, String password)
        {
            return CustomerController.updateProfile(iD, name, email, gender, address, password);
        }

        [WebMethod]
        public String deleteAccount(int iD)
        {
            return CustomerController.deleteAccount(iD);
        }

        [WebMethod]
        public bool InsertNewAlbum(string name, int artistId, string description, int price, int stock, string image)
        {
            return AlbumController.InsertNewAlbum(name, artistId, description, price, stock, image);
        }

        [WebMethod]
        public string GetAlbumByID(int id)
        {
            Album album = AlbumController.GetAlbumByID(id);
            string json = JsonConvert.SerializeObject(album, Formatting.None, new JsonSerializerSettings() {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return json;
        }

        [WebMethod]
        public string GetAllAlbums()
        {
            List<Album> albums = AlbumController.GetAllAlbums();
            string json = JsonConvert.SerializeObject(albums);
            return json;
        }
    }
}
