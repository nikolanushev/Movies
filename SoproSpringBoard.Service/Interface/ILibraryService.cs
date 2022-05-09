using SoproSpringBoard.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoproSpringBoard.Service.Interface
{
    public interface ILibraryService
    {
        LibraryDTO getLibraryInfo(string userId);
        bool deleteMovieFromLibrary(string userId, int movieId);
    }
}
