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

        public IActionResult getAll() // '/Package/getAll
        {
            

            return View();
        }
    }
}
