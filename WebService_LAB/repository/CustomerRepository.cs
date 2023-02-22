using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_LAB.ado_model;
using WebService_LAB.factory;

namespace WebService_LAB.repository
{
    public class CustomerRepository
    {
        private static WebServiceDatabaseEntities webServiceDatabaseInstance;
        private static WebServiceDatabaseEntities getInstance()
        {
            if (webServiceDatabaseInstance == null)
            {
                webServiceDatabaseInstance = new WebServiceDatabaseEntities();
            }
            return webServiceDatabaseInstance;
        }

        public static Customer checkUniqueEmail(String email)
        {
            try
            {
                return (from customer in CustomerRepository.getInstance().Customers
                        where customer.CustomerEmail == email
                        select customer).First();
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public static List<Customer> getAllCustomer()
        {
            return (from customers in CustomerRepository.getInstance().Customers 
                    select customers).ToList();
        }

        public static Customer getACustomer(String email, String password)
        {
            try
            {
                return (from customer in CustomerRepository.getInstance().Customers
                        where customer.CustomerEmail == email && customer.CustomerPassword == password
                        select customer).First();
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public static String addCustomer(String name, String email, String gender, String address, String password)
        {
            Customer newCustomer = CustomerFactory.makeNewCustomer(name, email, gender, address, password);
            
            if(newCustomer == null)
            {
                return "Customer insertion failed! Please try again later!";
            }
            else
            {
                CustomerRepository.getInstance().Customers.Add(newCustomer);
                CustomerRepository.getInstance().SaveChanges();
                return "Customer Insertion successful!";
            }
        }
    }
}