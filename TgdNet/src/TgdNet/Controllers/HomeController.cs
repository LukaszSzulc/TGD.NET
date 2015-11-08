using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TgdNet.Controllers
{
    using System.Security.Principal;

    using Microsoft.CodeAnalysis.CSharp.Syntax;

    using TgdNet.Binders;
    using TgdNet.Models;

    //[Route("/api/[controller]")]
    public class HomeController
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return new ViewResult { ViewName = "Index" };
        }

        [HttpGet("/api/[controller]")]
        public SampleModel Get()
        {
            var sampleModel = new SampleModel();
            sampleModel.SampleHeader = "SampleHeader";
            sampleModel.SortOrder = "1";
            return sampleModel;
        }

        [HttpPost("/api/[controller]/HederMapping")]
        public void HeaderMapping(SampleModel model)
        {
            
        }

        public void Principal([ModelBinder(BinderType = typeof(IPrincipalBinder),Name = "Principal")] IIdentity identity)
        {
            
        }


    }
}
