using Entities.Absract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity
    {
        List<T> GetAll();
        List<T> GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
