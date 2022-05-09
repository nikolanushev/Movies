using Microsoft.EntityFrameworkCore;
using SoproSpringBoard.Domain.Identity;
using SoproSpringBoard.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoproSpringBoard.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<MovieApplicationUser> entities;
        string errorMessage = string.Empty;

        public UserRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<MovieApplicationUser>();
        }

        public MovieApplicationUser Get(string id)
        {
            var user = entities.Include(z => z.UserLibrary).
                Include("UserLibrary.MoviesInLibrary").
                Include("UserLibrary.MoviesInLibrary.Movie").
                SingleOrDefault(x => x.Id == id);
            if (user == null)
            {
                throw new ArgumentNullException("user");
            }
            return user;
        }

        public IEnumerable<MovieApplicationUser> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(MovieApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(MovieApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }

        public void Delete(MovieApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }
    }
}
