using BurgerWebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BurgerWebApp.Services.Abstraction
{
    public interface IOrderDetailsService
    {
        void Save(OrderDetailsViewModel model);
        int Delete(int id);
    }
}
