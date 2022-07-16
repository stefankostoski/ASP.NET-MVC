using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModel;
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

        public BurgerService(IRepository<Burger> burgerRepository)
        {
            _burgerRepository = burgerRepository;
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
            throw new NotImplementedException();
        }
    }
}
