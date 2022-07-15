using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModels;
using BurgerWebApp.Storage;

namespace BurgerWebApp.DataAccess.Repositories
{
    public class BurgerRepository : IRepository<Burger>
    {

        public List<Burger> GetAll()
        {
            return BurgerDb.Burgers.ToList();
        }

        public Burger GetById(int id)
        {
            return BurgerDb.Burgers.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Burger entity)
        {
            BurgerDb.Burgers.Add(entity);
        }

        public void Update(Burger entity)
        {
            var item = GetById(entity.Id);
            if (item != null)
            {
                int index = BurgerDb.Burgers.IndexOf(item);
                BurgerDb.Burgers[index] = entity;
            }
        }
        public void DeleteById(int id)
        {
            var item = GetById(id);
            if (item != null)
            {
                BurgerDb.Burgers.Remove(item);
            }
        }
    }
}
