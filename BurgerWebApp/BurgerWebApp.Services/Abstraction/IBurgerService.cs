using BurgerWebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BurgerWebApp.Services.Abstraction
{
    public interface IBurgerService
    {
        List<BurgerViewModel> GetAll();
        BurgerViewModel GetById(int id);
        void Save(BurgerViewModel model);
        void Delete(int id);
    }
}
