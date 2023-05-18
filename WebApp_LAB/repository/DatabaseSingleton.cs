using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_LAB.ado_model;

namespace WebApp_LAB.repository
{
    public class DatabaseSingleton
    {
        private static LocalDatabaseEntities db;
        public static LocalDatabaseEntities getInstance()
        {
            if (db == null)
            {
                db = new LocalDatabaseEntities();
            }
            return db;
        }
    }
}