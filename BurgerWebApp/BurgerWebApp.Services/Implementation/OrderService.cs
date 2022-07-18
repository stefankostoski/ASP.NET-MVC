using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModels;
using BurgerWebApp.Mappers;
using BurgerWebApp.Models;
using BurgerWebApp.Services.Abstraction;

namespace BurgerWebApp.Services.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;
        public OrderService(IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public List<OrderViewModel> GetAll()
        {
            var orders = _orderRepository.GetAll().Select(x => x.ToViewModel()).OrderBy(x => x.Id).ToList();
            return orders;
        }

        public OrderViewModel Details(int id)
        {
            var order = _orderRepository.GetById(id);

            if (order == null)
            {
                throw new Exception("Order not found");
            }

            return order.ToViewModel();
        }

        public int Save(OrderViewModel model)
        {
            var order = new Order(model.FullName, model.Address, model.IsDelivered, model.Location);

            _orderRepository.Insert(order);

            return order.Id;
        }
        public void Delete(int id)
        {
            var existingOrder = _orderRepository.GetById(id);

            if (existingOrder == null)
            {
                throw new Exception($"Order with id {id} does not exist");
            }

            _orderRepository.DeleteById(existingOrder.Id);
        }
    }
}
