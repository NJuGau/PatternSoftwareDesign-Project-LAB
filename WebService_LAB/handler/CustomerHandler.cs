using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_LAB.repository;
using WebService_LAB.ado_model;

namespace WebService_LAB.handler
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

        public static Customer register(String name, String email, String gender, String address, String password)
        {
            return CustomerRepository.addCustomer(name, email, gender, address, password);
        }

        public static Customer getCustomerProfile(int iD)
        {
            return CustomerRepository.getCustomerProfile(iD);
        }

        public static Customer updateProfile(int iD, String name, String email, String gender, String address, String password)
        {
            return CustomerRepository.updateProfile(iD, name, email, gender, address, password);
        }

        public static Customer deleteAccount(int iD)
        {
            return CustomerRepository.deleteCustomer(iD);
        }
    }
}