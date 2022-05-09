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
    public class LibraryService : ILibraryService
    {
        public readonly IUserRepository _userRepository;
        public readonly IRepository<MoviesInLibrary> _moviesInLibraryRepository;
        public readonly IRepository<Library> _libraryRepository;
        public LibraryService(IUserRepository userRepository,
                IRepository<MoviesInLibrary> moviesInLibraryRepository,
                IRepository<Library> libraryRepository)
        {
            _userRepository = userRepository;
            _moviesInLibraryRepository = moviesInLibraryRepository;
            _libraryRepository = libraryRepository;
        }

        public bool deleteMovieFromLibrary(string userId, int movieId)
        {
            if (!string.IsNullOrEmpty(userId) && movieId != null)
            {
                var loggInUser = _userRepository.Get(userId);
                var userLibrary = loggInUser.UserLibrary;
                var itemToDelete = userLibrary.MoviesInLibrary.Where(z => z.MovieId == movieId).FirstOrDefault();
                userLibrary.MoviesInLibrary.Remove(itemToDelete);
                _libraryRepository.Update(userLibrary);
                return true;
            }
            else
            {
                return false;
            }
        }

        public LibraryDTO getLibraryInfo(string userId)
        {
            var user = _userRepository.Get(userId);
            var userLibrary = user.UserLibrary;

            var movieList = userLibrary.MoviesInLibrary.Select(z => new
            {
                MovieName = z.Movie.MovieName,
                MovieImage = z.Movie.MovieImage
            });

            LibraryDTO model = new LibraryDTO
            {
                MoviesInLibraries = userLibrary.MoviesInLibrary.ToList()
            };

            return model;
        }
    }
}
