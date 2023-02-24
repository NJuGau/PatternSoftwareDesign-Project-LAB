using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_LAB.ado_model;

namespace WebService_LAB.factory
{
    public class CustomerFactory
    {
        public static Customer makeNewCustomer(String name, String email, String gender, String address, String password)
        {
            Customer customer = new Customer();
            customer.CustomerName = name;
            customer.CustomerEmail = email;
            customer.CustomerGender = gender;
            customer.CustomerAddress = address;
            customer.CustomerPassword = password;
            customer.CustomerRole = "Custo";
            return customer;
        }
    }
}