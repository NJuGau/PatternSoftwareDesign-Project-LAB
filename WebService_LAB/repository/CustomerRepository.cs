using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_LAB.ado_model;

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

        public static Customer addCustomer(String name, String email, String gender, String address, String password)
        {
            try
            {
                //TODO: insert query
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}