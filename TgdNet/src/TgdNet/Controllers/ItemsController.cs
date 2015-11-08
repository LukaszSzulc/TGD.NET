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
        private readonly ItemsContext context;

        private List<ItemModel> items;

        public ItemsController(ItemsContext context)
        {
            this.context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(this.context.Items.ToList());
        }

        public IActionResult AddNewItem()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewItem(ItemModel model)
        {
            model.Id = Guid.NewGuid().ToString("N");
            this.context.Items.Add(model);
            await this.context.SaveChangesAsync();
            return this.RedirectToAction("Index");
        }

        public IActionResult Details(string id)
        {
            return View();
        }
    }
}
