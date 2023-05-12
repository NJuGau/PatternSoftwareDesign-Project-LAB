using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_LAB.ado_model;

namespace WebService_LAB.repository
{
    public class DatabaseSingleton
    {
        private static WebServiceDatabaseEntities webServiceDatabaseInstance;
        public static WebServiceDatabaseEntities getInstance()
        {
            if (webServiceDatabaseInstance == null)
            {
                webServiceDatabaseInstance = new WebServiceDatabaseEntities();
            }
            return webServiceDatabaseInstance;
        }
    }
}