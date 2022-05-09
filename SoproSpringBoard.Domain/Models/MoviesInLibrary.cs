using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SoproSpringBoard.Domain.Models
{
    public class MoviesInLibrary : BaseEntity
   {
        public int MovieId { get; set; }

        public int LibraryId { get; set; }

        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }

        [ForeignKey("LibraryId")]
        public Library Library { get; set; }
    }
}
