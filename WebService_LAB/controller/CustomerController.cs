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
        public static Boolean checkAlphaNumeric(String str)
        {
            Boolean isAlpha = false;
            Boolean isNumeric = false;
            foreach (char character in str)
            {
                if((character >= 'A' && character <= 'Z') || (character >= 'a' && character <= 'z'))
                {
                    isAlpha = true;
                }
                else if (character >= '0' && character <= '9')
                {
                    isNumeric = true;
                }
                else
                {
                    return false;
                }

                if(isNumeric == true && isAlpha == true)
                {
                    return true;
                }
            }
            return false;
        }

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
            if(name.Length <= 5 || name.Length >= 50)
            {
                return JsonConvert.SerializeObject("Name must be between 5 and 50 characters!");
            }
            else if (!checkAlphaNumeric(password))
            {
                return JsonConvert.SerializeObject("Password must be alphanumeric!");
            }
            return "ello";
        }
    }
}