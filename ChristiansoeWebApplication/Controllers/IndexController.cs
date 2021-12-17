using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace ChristiansoeWebApplication.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            List<Models.Package> packages = new List<Models.Package>();
            SqliteConnection connection = Persistence.PersistenceService.GetConnection();

            connection.Open();

            SqliteCommand command = connection.CreateCommand();

            command.CommandText =
            @"
                SELECT id, title, description, start_date, end_date FROM packages
                WHERE custom = 0
            ";

            ViewData["packages"] = packages;

            return View();
        }
    }
}
