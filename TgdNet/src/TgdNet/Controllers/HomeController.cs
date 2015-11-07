using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TgdNet.Controllers
{
    public class HomeController
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return new ViewResult { ViewName = "Index" };
        }

        [HttpGet("/api/Home/")]
        public string Get()
        {
            return Guid.NewGuid().ToString("N");
        }


    }
}
