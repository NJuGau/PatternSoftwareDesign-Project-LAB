using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebService_LAB.controller;

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

        //Login:
        //    input: email dan password
        //    output: object customer yang ada, null, atau error message
        [WebMethod]
        public String login(String email, String password)
        {
            return CustomerController.login(email, password);
        }

        //register:
        //    input: name, email, gender, address, password
        //    output: object customer yang baru dibuat, null, atau error message
        [WebMethod]
        public String register(String name, String email, String gender, String address, String password)
        {
            return CustomerController.register(name, email, gender, address, password);
        }

        //view Profile:
        //    input: ID
        //    output: Object customer yang dicari, atau null
        [WebMethod]
        public String viewProfile(int iD)
        {
            return CustomerController.getCustomerProfile(iD);
        }

        //update profile:
        //    input: id, name, email, gender, address, password
        //    output: object customer yang diupdate, null, atau error message 
        [WebMethod]
        public String updateProfile(int iD, String name, String email, String gender, String address, String password)
        {
            return CustomerController.updateProfile(iD, name, email, gender, address, password);
        }

        //delete account: 
        //    input: ID
        //    ouput: message account berhasil di delete
        [WebMethod]
        public String deleteAccount(int iD)
        {
            return CustomerController.deleteAccount(iD);
        }

    }
}
