using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_LAB.repository;
using WebApp_LAB.ado_model;

namespace WebApp_LAB.handler
{
    public class CustomerHandler
    {
        public static Customer checkUniqueEmail(String email)
        {
            return CustomerRepository.checkUniqueEmail(email);
        }

        public static Customer login(String email, String password)
        {
            return CustomerRepository.getACustomer(email, password);
        }

        public static void register(String name, String email, String gender, String address, String password)
        {
            CustomerRepository.addCustomer(name, email, gender, address, password);
        }

        public static Customer getCustomerProfile(int iD)
        {
            return CustomerRepository.getCustomerProfile(iD);
        }

        public static void updateProfile(int iD, String name, String email, String gender, String address, String password)
        {
            CustomerRepository.updateProfile(iD, name, email, gender, address, password);
        }

        public static Customer deleteAccount(int iD)
        {
            return CustomerRepository.deleteCustomer(iD);
        }
    }
}