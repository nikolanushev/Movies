using SoproSpringBoard.Domain.DTO;
using SoproSpringBoard.Domain.Models;
using SoproSpringBoard.Repository.Interface;
using SoproSpringBoard.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoproSpringBoard.Service.Implementation
{
    public class MovieService : IMovieService
    {
        public readonly IRepository<Movie> _movieRepository;
        public readonly IRepository<MoviesInLibrary> _moviesInLibraryRepository;

        public readonly IUserRepository _userRepository;

        public MovieService(IRepository<Movie> movieRepository, IRepository<MoviesInLibrary> moviesInLibraryRepository, IUserRepository userRepository)
        {
            _movieRepository = movieRepository;
            _moviesInLibraryRepository = moviesInLibraryRepository;
            _userRepository = userRepository;
        }

        public bool AddToLibrary(AddToLibraryDTO item, string userID)
        {
            var user = this._userRepository.Get(userID);

            var userLibrary = user.UserLibrary;

            if (userLibrary != null)
            {
                var movie = this.GetDetailsForMovie(item.MovieID);

                if (movie != null)
                {
                    MoviesInLibrary itemToAdd = new MoviesInLibrary
                    {
                        Movie = movie,
                        MovieId = movie.Id,
                        Library = userLibrary,
                        LibraryId = userLibrary.Id,
                    };

                    _moviesInLibraryRepository.Insert(itemToAdd);
                    return true;
                }
                return false;
            }
            return false;
        }

        public void CreateNewMovie(Movie p)
        {
            this._movieRepository.Insert(p);
        }


        public void DeleteMovie(int id)
        {
            var product = _movieRepository.Get(id);
            this._movieRepository.Delete(product);
        }

        public List<Movie> GetAllMovies()
        {
            return _movieRepository.GetAll().ToList();
        }

        public Movie GetDetailsForMovie(int id)
        {
            return _movieRepository.Get(id);
        }

        public LibraryDTO GetLibraryDetails(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateExistingMovie(Movie p)
        {
            this._movieRepository.Update(p);
        }
    }
}
