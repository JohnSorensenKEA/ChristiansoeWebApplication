using System;
using Microsoft.Data.Sqlite;

namespace ChristiansoeWebApplication.Persistence
{
    public class PersistenceService
    {
        private static SqliteConnection connection = new SqliteConnection("Data Source=database.db");

        public static SqliteConnection GetConnection()
        {
            return connection;
        }
    }
}
