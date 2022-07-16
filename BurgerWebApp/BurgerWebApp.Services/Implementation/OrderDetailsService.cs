using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModel;
using BurgerWebApp.DomainModels;
using BurgerWebApp.Models;
using BurgerWebApp.Services.Abstraction;

namespace BurgerWebApp.Services.Implementation
{
    public class OrderDetailsService : IOrderDetailsService
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<OrderDetails> _orderDetailsRepository;
        public OrderDetailsService(IRepository<Order> orderRepository, IRepository<OrderDetails> orderDetailsRepository)
        {
            _orderRepository = orderRepository;
            _orderDetailsRepository = orderDetailsRepository;
        }

        public void Save(OrderDetailsViewModel model)
        {
            var order = _orderRepository.GetById(model.OrderId);

            if (order == null)
            {
                throw new Exception($"Order does not exist");
            }

            var burgerId = _orderDetailsRepository.GetById(model.Id);

            if (burgerId == null)
            {
                throw new Exception($"Burger item does not exist");
            }

            if (model.Quantity <= 0)
            {
                throw new Exception($"Quantity must be grater than 0");
            }

            var orderItem = new OrderDetails(model.OrderId, model.BurgerId, model.PricePerItem, model.Quantity);

            _orderDetailsRepository.Add(orderItem);

            _orderRepository.Update(order);
        }
        public int Delete(int id)
        {
            var existingOrder = _orderRepository.GetAll().FirstOrDefault(x => x.Id == id);

            if (existingOrder == null)
            {
                throw new Exception($"Order that contains order item with {id} does not exist");
            }

            //var existingOrderItem = existingOrder.OrderDetails;
            //existingOrder.OrderDetails.Remove(existingOrderItem);

            //_orderRepository.Update(existingOrder);

            return existingOrder.Id;
        }
    }
}
