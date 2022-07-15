using BurgerWebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BurgerWebApp.Services.Abstraction
{
    public interface IOrderService
    {
        List<OrderViewModel> GetAll();
        OrderViewModel GetById(int id);
        void Save(OrderViewModel model);
        void Delete(int id);
        List<SelectListItem> GetBurgerSelectList();
    }
}
