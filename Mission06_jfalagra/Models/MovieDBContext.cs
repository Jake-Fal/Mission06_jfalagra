using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_jfalagra.Models
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext(DbContextOptions<MovieDBContext> options) : base(options)
        {

        }

        public DbSet<AddMovieModel> responses { get; set; }
        public DbSet<Genre> genres { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Genre>().HasData(
                new Genre { CategoryID = 1, CategoryName = "Horror" },
                new Genre { CategoryID = 2, CategoryName = "Comedy" },
                new Genre { CategoryID = 3, CategoryName = "Action" });
            mb.Entity<AddMovieModel>().HasData(

                new AddMovieModel
                {
                    MovieId = 1,
                    Title = "IT",
                    Year = 2017,
                    Director = "Andy Muschietti",
                    Rating = "R",
                    Edited = true,
                    Lent_To = null,
                    Notes = null,
                    CategoryID = 1
                },
                new AddMovieModel
                {
                    MovieId = 2,
                    Title = "Anchorman",
                    Year = 2004,
                    Director = "Adam McKay",
                    Rating = "PG-13",
                    Edited = true,
                    Lent_To = null,
                    Notes = null,
                    CategoryID = 2
                },
                new AddMovieModel
                {
                    MovieId = 3,
                    Title = "Top Gun",
                    Year = 1986,
                    Director = "Tony Scott",
                    Rating = "PG",
                    Edited = true,
                    Lent_To = null,
                    Notes = null,
                    CategoryID = 3
                }
                );
        }
    }
}
