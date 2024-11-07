using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ItemsController : Controller
    {
        // GET: ItemsController
        public ActionResult Overview()
        {
            var item = new Item() { Name = "Keyboard" };  
            return View(item);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

    }
}
