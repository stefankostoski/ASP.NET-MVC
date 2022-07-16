using BurgerWebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BurgerWebApp.Services.Abstraction
{
    public interface IOrderService
    {
        List<OrderViewModel> GetAll();
        OrderViewModel Details(int id);
        int Save(OrderViewModel model);
        void Delete(int id);
    }
}
