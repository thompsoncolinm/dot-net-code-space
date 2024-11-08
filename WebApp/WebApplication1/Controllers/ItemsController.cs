using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ItemsController : Controller
    {
        // GET: ItemsController
        public ActionResult Overview(Item item)
        {
            if (item == null)
            {
                item = new Item() { Name = "Keyboard" };
            } else
            {
                ViewBag.item = item;
            }
            return View(item);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Submit(Item item)
        {
            // return Content("Name=" + item.Name);

            return RedirectToAction("Overview", item);

            
        }

    }
}
