using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TgdNet.ViewComponents
{
    using Microsoft.AspNet.Mvc;

    public class ItemsOnSaleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int arg)
        {
            return View(arg);
        }
    }
}
