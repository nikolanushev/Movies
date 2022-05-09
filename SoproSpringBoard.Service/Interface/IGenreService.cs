using SoproSpringBoard.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoproSpringBoard.Service.Interface
{
    public interface IGenreService
    {
        List<Genre> GetAllGenres();
        void CreateNewGenre(Genre p);
    }
}
