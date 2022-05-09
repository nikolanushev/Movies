using SoproSpringBoard.Domain.DTO;
using SoproSpringBoard.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoproSpringBoard.Service.Interface
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();

        Movie GetDetailsForMovie(int id);
        void CreateNewMovie(Movie p);
        void UpdateExistingMovie(Movie p);
        LibraryDTO GetLibraryDetails(int id);
        void DeleteMovie(int id);
        bool AddToLibrary(AddToLibraryDTO item, string userID);
    }
}
