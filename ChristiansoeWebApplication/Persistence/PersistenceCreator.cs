using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace ChristiansoeWebApplication.Persistence
{
    public class PersistenceCreator
    {
        
        public static void createDatabase()
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();

                SqliteCommand dropPackageActivityRelationTable = connection.CreateCommand();
                dropPackageActivityRelationTable.CommandText =
                @"
                    DROP TABLE IF EXISTS projects_technologies_relations
                ";

                SqliteCommand dropPackageTable = connection.CreateCommand();
                dropPackageTable.CommandText =
                @"
                    DROP TABLE IF EXISTS packages
                ";

                SqliteCommand dropActivitiesTable = connection.CreateCommand();
                dropActivitiesTable.CommandText =
                @"
                    DROP TABLE IF EXISTS activities
                ";

                SqliteCommand dropCategoriesTable = connection.CreateCommand();
                dropCategoriesTable.CommandText =
                @"
                    DROP TABLE IF EXISTS categories
                ";


                SqliteCommand categoriesTable = connection.CreateCommand();
                categoriesTable.CommandText =
                @"
                    CREATE TABLE categories (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        name TEXT NOT NULL
                    )
                ";

                SqliteCommand activitiesTable = connection.CreateCommand();
                activitiesTable.CommandText =
                @"
                    CREATE TABLE activities (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        title TEXT NOT NULL,
                        description TEXT NOT NULL,
                        duration INTEGER NOT NULL,
                        start_date TEXT,
                        end_date TEXT,
                        latitude TEXT NOT NULL,
                        longitude TEXT NOT NULL,
                        category_id INTEGER NOT NULL,
                        FOREIGN KEY (category_id)
                            REFERENCES categories (id)
                                ON DELETE CASCADE
                                ON UPDATE NO ACTION
                    )
                ";

                SqliteCommand packageTable = connection.CreateCommand();
                packageTable.CommandText =
                @"
                    CREATE TABLE packages (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        title TEXT NOT NULL,
                        description TEXT NOT NULL,
                        custom INTEGER NOT NULL,
                        start_date TEXT,
                        end_date TEXT,
                        code TEXT NOT NULL
                    )
                ";

                SqliteCommand packageActivityRelationTable = connection.CreateCommand();
                packageActivityRelationTable.CommandText =
                @"
                    CREATE TABLE projects_technologies_relations (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        package_id INTEGER NOT NULL,
                        activity_id INTEGER NOT NULL,
                        FOREIGN KEY (package_id)
                            REFERENCES packages (id)
                                ON DELETE CASCADE
                                ON UPDATE NO ACTION,
                        FOREIGN KEY (activity_id)
                            REFERENCES activities (id)
                                ON DELETE CASCADE
                                ON UPDATE NO ACTION
                    )
                ";

                dropPackageActivityRelationTable.ExecuteNonQuery();
                dropPackageTable.ExecuteNonQuery();
                dropActivitiesTable.ExecuteNonQuery();
                dropCategoriesTable.ExecuteNonQuery();

                categoriesTable.ExecuteNonQuery();
                activitiesTable.ExecuteNonQuery();
                packageTable.ExecuteNonQuery();
                packageActivityRelationTable.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
