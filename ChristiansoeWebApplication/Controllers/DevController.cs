using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristiansoeWebApplication.Controllers
{
    public class DevController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string SetDatabase()
        {
            try
            {
                Persistence.PersistenceCreator.createDatabase();
                return "Database set successfully";
            }
            catch (Exception e)
            {
                Console.WriteLine("Database setting failed");
                return "Database setting failed";
            }
            
        }
    }
}
