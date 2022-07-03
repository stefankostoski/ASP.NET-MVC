﻿using BurgerWebApp.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace BurgerWebApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            var orders = Storage.BurgerDb.Orders.Select(x=>x.ToViewModel()).ToList();
            return View(orders);
        }

        public IActionResult Details(int id)
        {


            return View();
        }
    }
}
