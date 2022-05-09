using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SoproSpringBoard.Domain.Models
{
    public class MovieInGenre
    {
        [ForeignKey("MovieId")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [ForeignKey("GenreId")]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
