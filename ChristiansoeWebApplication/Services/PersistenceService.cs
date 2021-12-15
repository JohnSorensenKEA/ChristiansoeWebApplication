using System;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;

namespace ChristiansoeWebApplication.Services
{
    public class PersistenceService
    {
        private static SqlConnection connection;

        public static void setConnection()
        {
            string connectionString = "";

            try
            {
                connection = new SqlConnection(connectionString);
           
                connection.Open();
            } catch (Exception e)
            {
                Console.WriteLine("Failed setting DB connection: " + e.Message);
            }
            
            
        }

        public static void getAllActivityCategories()
        {
            string queryString = "SELECT * FROM master.ch_exp.activity_categories";

            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine("\t{0}\t{1}",
                        reader[0], reader[1]);
            }
            reader.Close();
        }
    }
}
