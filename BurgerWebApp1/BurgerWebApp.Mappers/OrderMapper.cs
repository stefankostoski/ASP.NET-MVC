using BurgerWebApp.DomainModels;
using BurgerWebApp.Models;

namespace BurgerWebApp.Mappers
{
    public static class OrderMapper
    {
        public static OrderViewModel ToViewModel(this Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                FullName = order.FullName,
                Address = order.Address,
                IsDelivered = order.IsDelivered,
                Location = order.Location
            };
        }
    }
}
