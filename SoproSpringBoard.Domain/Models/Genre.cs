using System;
using System.Collections.Generic;
using System.Text;

namespace SoproSpringBoard.Domain.Models
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
