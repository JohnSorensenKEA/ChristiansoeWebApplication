using ChristiansoeWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristiansoeWebApplication.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;

        

        public IndexModel()    //ILogger<IndexModel> logger)
        {
            //_logger = logger;
        }

        public List<Models.Package> Packages { get; set; }

        public void OnGet()
        {
            
        }

        public async Task<List<Package>> GetPackages() => (List<Package>) await ViewData["packages"];

        public void Test()
        {
            
        }
    }
}
