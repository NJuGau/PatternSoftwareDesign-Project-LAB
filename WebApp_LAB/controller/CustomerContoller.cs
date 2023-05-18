using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_LAB.handler;
using WebApp_LAB.ado_model;

namespace WebApp_LAB.controller
{
    public class CustomerController
    {
        private static Boolean checkUniqueEmail(String email)
        {
            Customer sameEmailCustomer = CustomerHandler.checkUniqueEmail(email);
            if (sameEmailCustomer == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static Boolean checkAlphaNumeric(String password)
        {
            Boolean isAlpha = false;
            Boolean isNumeric = false;
            foreach (char character in password)
            {
                if ((character >= 'A' && character <= 'Z') || (character >= 'a' && character <= 'z'))
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

                if (isNumeric == true && isAlpha == true)
                {
                    return true;
                }
            }
            return false;
        }

        public static string checkName(string name)
        {
            
            if (name.Equals(""))
            {
                return "Name must be filled!";
            }
            else if (name.Length <= 5 || name.Length >= 50)
            {
                return "Name must be between 5 and 50 characters!";
            }
            return "";
        }

        public static string checkEmail(string email)
        {
            if (email.Equals(""))
            {
                return "Email must be filled!";
            }
            else if (!checkUniqueEmail(email))
            {
                return "Choose another email address. Email must be unique!";
            }
            return "";
        }

        public static string checkGender(string gender)
        {
            if (gender.Equals(""))
            {
                return "Gender must be selected!";
            }
            return "";
        }

        public static string checkAddress(string address)
        {
            if (address.Equals(""))
            {
                return "Address must be filled!";
            }
            else if (!address.EndsWith("Street"))
            {
                return "Address must ends with 'Street'!";
            }
            return "";
        }

        public static string checkPassword(string password)
        {
            if (password.Equals(""))
            {
                return "Password must be filled!";
            }
            else if (!checkAlphaNumeric(password))
            {
                return "Password must be alphanumeric!";
            }
            return "";
        }

        public static Customer login(string email, string password)
        {
            email = email.ToString();
            password = password.ToString();

            // Use Required Field Validator to check isFilled

            return CustomerHandler.login(email, password);
        }

        public static void register(string name, string email, string gender, string address, string password)
        {
            name = name.ToString();
            email = email.ToString();
            gender = gender.ToString();
            address = address.ToString();
            password = password.ToString();

            CustomerHandler.register(name, email, gender, address, password);
        }

        public static Customer getCustomerProfile(int iD)
        {
            iD = Convert.ToInt32(iD);
            return CustomerHandler.getCustomerProfile(iD);
        }

        public static void updateProfile(int iD, String name, String email, String gender, String address, String password)
        {
            name = name.ToString();
            email = email.ToString();
            gender = gender.ToString();
            address = address.ToString();
            password = password.ToString();

            CustomerHandler.updateProfile(iD, name, email, gender, address, password);
        }

        //public static string deleteAccount(int iD)
        //{
        //    iD = Convert.ToInt32(iD);
        //    Customer checkEntityStillExist = CustomerHandler.deleteAccount(iD);

        //    String message = "";
        //    if (checkEntityStillExist == null)
        //    {
        //        message = "Account deletion successful!";
        //    }
        //    else
        //    {
        //        message = "Account deletion error! Please try again later!";
        //    }

        //    return message;
        //}
    }
}