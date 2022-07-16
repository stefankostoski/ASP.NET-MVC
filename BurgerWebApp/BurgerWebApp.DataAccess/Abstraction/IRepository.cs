﻿using BurgerWebApp.DomainModel;

namespace BurgerWebApp.DataAccess.Abstraction
{
    public interface IRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void DeleteById(int id);
        void Add(OrderDetails orderItem);
    }
}
