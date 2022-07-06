using BurgerWebApp.DomainModels;
using BurgerWebApp.Models;

namespace BurgerWebApp.Mappers
{
    public static class OrderDetailsMapper
    {
        public static OrderDetailsViewModel ToViewModel(this OrderDetails orderdetails)
        {
            return new OrderDetailsViewModel
            {
                Id = orderdetails.Id,
                BurgerId = orderdetails.BurgerId,
                Quantity = orderdetails.Quantity
            };
        }
    }
}
