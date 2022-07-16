using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModel;
using BurgerWebApp.Storage;

namespace BurgerWebApp.DataAccess.Repositories
{
    public class OrderDetailsRepository : IRepository<OrderDetails>
    {

        private readonly BurgerDb _dbContext;

        public OrderDetailsRepository(BurgerDb dbContext)
        {
            _dbContext = dbContext;
        }

        public List<OrderDetails> GetAll()
        {
            return _dbContext.OrderDetails.ToList();
        }
       

        public OrderDetails GetById(int id)
        {
            return _dbContext.OrderDetails.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(OrderDetails entity)
        {
            _dbContext.OrderDetails.Add(entity);
        }

        public void Update(OrderDetails entity)
        {
            var item = GetById(entity.Id);
            if (item != null)
            {
                _dbContext.OrderDetails.Update(entity);
                _dbContext.SaveChanges();
            }
        }
        public void DeleteById(int id)
        {
            var item = GetById(id);
            if (item != null)
            {
                _dbContext.OrderDetails.Remove(item);
            }
        }
    }
}
