using SoproSpringBoard.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoproSpringBoard.Repository.Interface
{
    public interface IMovieRepository
    {
        List<Movie> getAllMovies();
        Movie getMovieDetails(BaseEntity model);
    }
}
