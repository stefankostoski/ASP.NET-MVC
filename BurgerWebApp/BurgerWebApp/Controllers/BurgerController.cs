using BurgerWebApp.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace BurgerWebApp.Controllers
{
    public class BurgerController : Controller
    {
        public IActionResult Index()
        {
            var menu = BurgerDb.Burgers.Select(x => x.ToViewModel()).ToList();
            return View(menu);
        }

        public IActionResult Details(int id)
        {
           return View();
        }
    }
}
