using SoproSpringBoard.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoproSpringBoard.Repository.Interface
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
