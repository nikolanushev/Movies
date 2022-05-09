using Microsoft.AspNet.Identity.EntityFramework;
using SoproSpringBoard.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoproSpringBoard.Domain.Identity
{
    public class MovieApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public virtual Library UserLibrary { get; set; }

    }
}
