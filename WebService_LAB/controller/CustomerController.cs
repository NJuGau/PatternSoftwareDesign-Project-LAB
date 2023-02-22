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
        public static Boolean checkUniqueEmail(String email)
        {
            Customer sameEmailCustomer = CustomerHandler.checkUniqueEmail(email);
            if(sameEmailCustomer == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean checkAlphaNumeric(String password)
        {
            Boolean isAlpha = false;
            Boolean isNumeric = false;
            foreach (char character in password)
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
            email = email.ToString();
            password = password.ToString();

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
            name = name.ToString();
            email = email.ToString();
            gender = gender.ToString();
            address = address.ToString();
            password = password.ToString();

            if (name.Equals(""))
            {
                return JsonConvert.SerializeObject("Name must be filled!");
            }
            else if(name.Length <= 5 || name.Length >= 50)
            {
                return JsonConvert.SerializeObject("Name must be between 5 and 50 characters!");
            }
            if (email.Equals(""))
            {
                return JsonConvert.SerializeObject("Email must be filled!");
            }
            else if (!checkUniqueEmail(email))
            {
                return JsonConvert.SerializeObject("Choose another email address. Email must be unique!");
            }
            else if (gender.Equals(""))
            {
                return JsonConvert.SerializeObject("Gender must be selected!");
            }
            else if (address.Equals(""))
            {
                return JsonConvert.SerializeObject("Address must be filled!");
            }
            else if (address.EndsWith("Street"))
            {
                return JsonConvert.SerializeObject("Address must ends with 'Street'!");
            }
            else if (password.Equals(""))
            {
                return JsonConvert.SerializeObject("Password must be filled!");
            }
            else if (!checkAlphaNumeric(password))
            {
                return JsonConvert.SerializeObject("Password must be alphanumeric!");
            }
            else
            {
                return CustomerHandler.register(name, email, gender, address, password);
            }
        }
    }
}