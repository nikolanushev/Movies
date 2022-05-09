using SoproSpringBoard.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoproSpringBoard.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<MovieApplicationUser> GetAll();
        MovieApplicationUser Get(string id);
        void Insert(MovieApplicationUser entity);
        void Update(MovieApplicationUser entity);
        void Delete(MovieApplicationUser entity);
    }
}
