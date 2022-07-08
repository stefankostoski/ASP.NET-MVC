using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModels;
using BurgerWebApp.Storage;

namespace BurgerWebApp.DataAccess.Repositories
{
    public class OrderDetailsRepository : IRepository<OrderDetails>
    {
        
        public List<OrderDetails> GetAll() => BurgerDb.OrderDetails;
       

        public OrderDetails GetById(int id)
        {
            return BurgerDb.OrderDetails.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(OrderDetails entity)
        {
            BurgerDb.OrderDetails.Add(entity);
        }

        public void Update(OrderDetails entity)
        {
            var item = GetById(entity.Id);
            if (item != null)
            {
                int index = BurgerDb.OrderDetails.IndexOf(item);
                BurgerDb.OrderDetails[index] = entity;
            }
        }
        public void DeleteById(int id)
        {
            var item = GetById(id);
            if (item != null)
            {
                BurgerDb.OrderDetails.Remove(item);
            }
        }
    }
}
