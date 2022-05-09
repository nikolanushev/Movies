
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SoproSpringBoard.Domain.Identity;
using SoproSpringBoard.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoproSpringBoard.Repository
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Library> Libraries { get; set; }
        public virtual DbSet<MoviesInLibrary> MoviesInLibrary { get; set; }
        public virtual DbSet<MovieInGenre> MoviesGenre { get; set; }
        public virtual DbSet<PersonInMovie> MoviesPerson { get; set; }
        public virtual DbSet<MovieApplicationUser> MovieApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<MoviesInLibrary>().HasKey(c => new { c.LibraryId, c.MovieId });
            builder.Entity<MovieInGenre>().HasKey(k => new { k.MovieId, k.GenreId });
            builder.Entity<PersonInMovie>().HasKey(k => new { k.MovieId, k.PersonId });

            builder
                .Entity<Genre>()
                .HasMany(p => p.Movies)
                .WithOne(p => p.Genres);

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
