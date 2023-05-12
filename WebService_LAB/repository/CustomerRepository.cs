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
        private static WebServiceDatabaseEntities db = DatabaseSingleton.getInstance();

        public static Customer checkUniqueEmail(String email)
        {
            try
            {
                return (from customer in db.Customers
                        where customer.CustomerEmail == email
                        select customer).First();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static List<Customer> getAllCustomer()
        {
            return (from customers in db.Customers
                    select customers).ToList();
        }

        public static Customer getACustomer(String email, String password)
        {
            try
            {
                return (from customer in db.Customers
                        where customer.CustomerEmail == email && customer.CustomerPassword == password
                        select customer).First();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static Customer addCustomer(String name, String email, String gender, String address, String password)
        {
            Customer newCustomer = CustomerFactory.makeNewCustomer(name, email, gender, address, password);

            if (newCustomer == null)
            {
                return null;
            }
            else
            {
                db.Customers.Add(newCustomer);
                db.SaveChanges();
                return newCustomer;
            }
        }

        public static Customer getCustomerProfile(int iD)
        {
            try
            {
                return (from customer in db.Customers
                        where customer.CustomerID == iD
                        select customer).First();
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public static Customer updateProfile(int iD, String name, String email, String gender, String address, String password)
        {

            try
            {
                Customer updatedCustomer = (from customer in db.Customers where customer.CustomerID == iD select customer).FirstOrDefault();

                updatedCustomer.CustomerName = name;
                updatedCustomer.CustomerEmail = email;
                updatedCustomer.CustomerGender = gender;
                updatedCustomer.CustomerAddress = address;
                updatedCustomer.CustomerPassword = password;

                db.SaveChanges();

                return updatedCustomer;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static Customer deleteCustomer(int iD)
        {
            Customer findDeletedCustomer = db.Customers.Find(iD);
            db.Customers.Remove(findDeletedCustomer);
            db.SaveChanges();

            return db.Customers.Find(iD);
        }
    }
}