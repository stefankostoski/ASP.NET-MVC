using BurgerWebApp.DomainModels;
using BurgerWebApp.Models;

namespace BurgerWebApp.Mappers
{
    public static class BurgerMapper
    {
        public static BurgerViewModel ToViewModel(this Burger burger)
        {
            return new BurgerViewModel
            {
                Id = burger.Id,
                Name = burger.Name,
                Price = burger.Price,
                Image = burger.Image,
                IsVegan = burger.IsVegan,
                IsVegetarian = burger.IsVegetarian,
                HasFries = burger.HasFries
            };
        }
    }
}