using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        private long add(long a)
        {
            return a;
        }
        [BindProperties(SupportsGet = true)]
        public class mymodel
            {
            public string firstname { get; set; }
            [BindProperty(SupportsGet = true)]
            public virtual address myaddress { get; set; }
        }
        [BindProperties(SupportsGet = true)]
        public class address
        {
            public string streetname { get; set; }
        }
        public IActionResult Index()
        {
            var n = new mymodel()
            {
                firstname = "feng",
                myaddress = new address() { streetname = "hiway" }

            }; 
            return View(n);
        }
        public IActionResult Privacy(mymodel m )
        {
            var t = HttpContext.Request.RouteValues; 
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
