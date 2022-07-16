using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModels;
using BurgerWebApp.Models;
using BurgerWebApp.Services.Abstraction;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BurgerWebApp.Services.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<SelectListItem> GetBurgerSelectList()
        {
            throw new NotImplementedException();
        }

        public OrderViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(OrderViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
