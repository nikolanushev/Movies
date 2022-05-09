using SoproSpringBoard.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoproSpringBoard.Domain.DTO
{
    public class AddToLibraryDTO
    {
        public Movie SelectedMovie { get; set; }
        public int MovieID { get; set; }
    }
}
