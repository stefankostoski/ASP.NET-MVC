using BurgerWebApp.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace BurgerWebApp.Controllers
{
    public class BurgerController : Controller
    {
        private readonly IBurgerService _burgerService;
        public IActionResult Index()
        {
            var burgers = _burgerService.GetAll();
            return View(burgers);
        }

        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
