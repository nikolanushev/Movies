using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SoproSpringBoard.Domain.Models
{
    public class PersonInMovie : BaseEntity 
    {
        [ForeignKey("MovieId")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [ForeignKey("PersonId")]
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
