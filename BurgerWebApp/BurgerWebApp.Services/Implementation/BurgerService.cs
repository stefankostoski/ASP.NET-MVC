using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModels;
using BurgerWebApp.Helpers;
using BurgerWebApp.Mappers;
using BurgerWebApp.Models;
using BurgerWebApp.Services.Abstraction;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BurgerWebApp.Services.Implementation
{
    public class BurgerService : IBurgerService
    {
        private readonly IRepository<Burger> _burgerRepository;
        private readonly IRepository<OrderDetails> _orderDetailsRepository;

        public BurgerService(IRepository<Burger> burgerRepository, IRepository<OrderDetails> orderDetailsRepository)
        {
            _burgerRepository = burgerRepository;
            _orderDetailsRepository = orderDetailsRepository;
        }

        public List<BurgerViewModel> GetAll()
        {
            var burgers = _burgerRepository.GetAll().Select(x => x.ToViewModel()).OrderBy(x => x.Name).ToList();
            return burgers;
        }

        public BurgerViewModel GetById(int id)
        {
            var burger = _burgerRepository.GetById(id);

            if (burger == null)
            {
                throw new Exception($"Burger with Id {id} not found");
            }

            return burger.ToViewModel();
        }

        public void Save(BurgerViewModel model)
        {
            if (string.IsNullOrEmpty(model.Name)
                || (model.Price <= 0)
                || string.IsNullOrEmpty(model.Image)
                || (model.IsVegetarian == null)
                || (model.IsVegan == null)
                || (model.HasFries == null))
            {
                throw new Exception($"All properties are required.");
            }

            if (_burgerRepository.GetAll().Any(x => x.Name.ToLower() == model.Name.ToLower() && x.Id != model.Id))
            {
                throw new Exception($"Burger with the name {model.Name} already exists");
            }

            if (model.Id == 0)
            {
                var burger = new Burger(CommonHelper.GetRandomId(), model.Name, model.Price, model.Image, model.IsVegan, model.IsVegetarian, model.HasFries);

                _burgerRepository.Insert(burger);

                return;
            }

            var existingBurger = _burgerRepository.GetById(model.Id);

            if (existingBurger == null)
            {
                throw new Exception($"Burger with id {model.Id} does not exist");
            }

            existingBurger.Name = model.Name;

            _burgerRepository.Update(existingBurger);
        }

        public void Delete(int id)
        {
            var existingBurger = _burgerRepository.GetById(id);

            if (existingBurger == null)
            {
                throw new Exception($"Burger with id: {id} does not exist");
            }

            var menuItems = _orderDetailsRepository.GetAll().Where(x => x.BurgerId == id).ToList();

            foreach (var menuItem in menuItems)
            {
                _orderDetailsRepository.DeleteById(menuItem.Id);
            }

            _burgerRepository.DeleteById(existingBurger.Id);
        }

        public List<SelectListItem> GetBurgerSelectList()
        {
            return _burgerRepository.GetAll().Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList();
        }
    }
}
