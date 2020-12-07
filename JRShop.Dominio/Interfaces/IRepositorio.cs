using JRShop.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace JRShop.Dominio.Interfaces
{
    public interface IRepositorio<T>
        where T : Entity
    {
        void Add(T obj);
        int SaveChanges();
        List<T> GetAll();
        T GetById(Guid? id);
        void Remove(Guid id);
    }
}
