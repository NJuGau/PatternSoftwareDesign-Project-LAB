using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_LAB.handler;
using WebService_LAB.ado_model;

namespace WebService_LAB.controller
{
    public class CustomerController
    {
        public static String login(String email, String password)
        {
            if (email.Length == 0)
            {
                return JsonConvert.SerializeObject("Email must be filled!");
            }
            else if(password.Length == 0)
            {
                return JsonConvert.SerializeObject("Password must be filled!");
            }
            return JsonConvert.SerializeObject(CustomerHandler.login(email, password));
        }

        public static String register(String name, String email, String gender, String address, String password)
        {
            if(name <= 5 || name >=50)
            return "ello";
        }
    }
}