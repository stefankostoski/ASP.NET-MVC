using BurgerWebApp.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace BurgerWebApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            return View(_orderService.GetAll());
        }

        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
