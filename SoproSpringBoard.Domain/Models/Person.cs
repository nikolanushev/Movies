using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoproSpringBoard.Domain.Models
{
    public class Person : BaseEntity 
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public PersonType Type { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Age must be a positive number > 0")]
        public int Age { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
