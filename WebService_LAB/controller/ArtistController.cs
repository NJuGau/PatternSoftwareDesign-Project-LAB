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

        public static Boolean AddNewArtist(String name,String image)
        {
            WebServiceDatabaseEntities db = new WebServiceDatabaseEntities();
            //List < Artist > artistslist = ArtistController.GetAllArtist();
            //foreach (Artist a in artistslist)
            //{
            //    if (String.Compare(a.ArtistName, name) == 0)
            //    {
            //        return "name is already taken";
            //    }
            //}
            String query = "SELECT * FROM Artist WHERE ArtistName = " + name;
            string connectionString = ConfigurationManager.ConnectionStrings["WebServiceDatabaseEntities"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if(String.Compare(reader.GetString(0), name) == 0)
                    {
                        return false;
                    }
                }
            }
            //return ArtistHandler.AddNewArtist(name, image);
            return true;
        }
    }
}