using SoproSpringBoard.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoproSpringBoard.Service.Interface
{
    public interface IGenreService
    {
        List<Genre> GetAllGenres();
        Genre GetDetailsForGenre(int id);
        void CreateNewGenre(Genre p);
    }
}
