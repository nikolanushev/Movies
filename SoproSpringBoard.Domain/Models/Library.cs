using System;
using System.Collections.Generic;
using System.Text;

namespace SoproSpringBoard.Domain.Models
{
    public class Library : BaseEntity
    {
        public string ApplicationUserId { get; set; }
        public ICollection<MoviesInLibrary> MoviesInLibrary { get; set; }
    }
}
