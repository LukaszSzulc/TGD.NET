using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TgdNet.Controllers
{
    using TgdNet.Model;

    public class ItemsController : Controller
    {
        private static List<ItemModel> items;

        static ItemsController()
        {
            items = new List<ItemModel>();
            items.Add(
                new ItemModel { Id = Guid.NewGuid().ToString("N"), IsOnSale = false, Name = "Bioshock", Price = 12.95m });
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(items);
        }

        public IActionResult AddNewItem()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewItem(ItemModel model)
        {
            model.Id = Guid.NewGuid().ToString("N");
            items.Add(model);
            return this.RedirectToAction("Index");
        }

        public IActionResult Details(string id)
        {
            return View();
        }
    }
}
