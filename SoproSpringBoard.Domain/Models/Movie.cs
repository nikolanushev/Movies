using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoproSpringBoard.Domain.Models
{
    public class Movie : BaseEntity
    {
        [Required]
        [Display(Name = "Name")]
        public string MovieName { get; set; }

        [Display(Name = "Image")]
        public string MovieImage { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public string MovieReleaseDate { get; set; }

        [Required]
        [Display(Name = "Rating")]
        public float MovieRating { get; set; }

        [Display(Name = "IMDB")]
        public string MovieIMBDURL { get; set; }

        public Genre Genres { get; set; }

        public ICollection<MoviesInLibrary> MoviesInLibrary { get; set; }

    }
}
