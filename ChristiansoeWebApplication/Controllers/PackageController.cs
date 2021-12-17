using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristiansoeWebApplication.Controllers
{
    public class PackageController : Controller // '/Package'
    {
        public IActionResult Index() // Root
        {
            return View();
        }

        public string GetAll() // '/Package/getAll
        {
            //Persistence.PersistenceCreator.createDatabase();


            return "Completed";
        }

        public string GetTest()
        {
            return "Testing Testing";
        }
    }
}
