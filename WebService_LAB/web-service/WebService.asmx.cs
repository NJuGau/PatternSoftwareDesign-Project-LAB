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
        public string HelloWorld()
        {
            return "Hello World";
        }

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
            //String query = "SELECT * FROM Artist WHERE ArtistName = '" + name+"'";
            return ArtistController.AddNewArtist(name, image);
            //return query;
            //return false;
        }
    }
}
