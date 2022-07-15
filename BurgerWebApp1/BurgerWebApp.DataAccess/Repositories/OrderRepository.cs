using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModels;
using BurgerWebApp.Storage;

namespace BurgerWebApp.DataAccess.Repositories
{
    public class OrderRepository : IRepository<Order>
    {

        public List<Order> GetAll() => BurgerDb.Orders;


        public Order GetById(int id)
        {
            return BurgerDb.Orders.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Order entity)
        {
            BurgerDb.Orders.Add(entity);
        }

        public void Update(Order entity)
        {
            var item = GetById(entity.Id);
            if (item != null)
            {
                int index = BurgerDb.Orders.IndexOf(item);
                BurgerDb.Orders[index] = entity;
            }
        }
        public void DeleteById(int id)
        {
            var item = GetById(id);
            if (item != null)
            {
                BurgerDb.Orders.Remove(item);
            }
        }
    }
}
