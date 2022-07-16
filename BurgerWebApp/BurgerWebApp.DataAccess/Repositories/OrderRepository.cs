using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModel;
using BurgerWebApp.DomainModels;
using BurgerWebApp.Storage;

namespace BurgerWebApp.DataAccess.Repositories
{
    public class OrderRepository : IRepository<Order>
    {

        private readonly BurgerDb _dbContext;

        public OrderRepository(BurgerDb dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Order> GetAll()
        { 
          return  _dbContext.Orders.ToList();
        }


        public Order GetById(int id)
        {
            return _dbContext.Orders.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Order entity)
        {
            _dbContext.Orders.Add(entity);
        }

        public void Update(Order entity)
        {
            var item = GetById(entity.Id);
            if (item != null)
            {
                _dbContext.Orders.Update(entity);
                _dbContext.SaveChanges();
            }
        }
        public void DeleteById(int id)
        {
            var item = GetById(id);
            if (item != null)
            {
                _dbContext.Orders.Remove(item);
            }
        }

        public void Add(OrderDetails orderItem)
        {
            throw new NotImplementedException();
        }
    }
}
