using SoproSpringBoard.Domain.Models;
using SoproSpringBoard.Repository.Interface;
using SoproSpringBoard.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoproSpringBoard.Service.Implementation
{
    public class GenreService : IGenreService
    {
        public readonly IRepository<Genre> _genreRepository;
        public readonly IUserRepository _userRepository;

        public GenreService(IRepository<Genre> genreRepository, IUserRepository userRepository)
        {
            _genreRepository = genreRepository;
            _userRepository = userRepository;
        }

        public void CreateNewGenre(Genre p)
        {
            this._genreRepository.Insert(p);
        }

        public List<Genre> GetAllGenres()
        {
            return _genreRepository.GetAll().ToList();
        }

        public Genre GetDetailsForGenre(int id)
        {
            return _genreRepository.Get(id);
        }
    }
}
