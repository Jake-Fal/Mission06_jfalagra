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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<AddMovieModel>().HasData(

                new AddMovieModel
                {
                    MovieId = 1,
                    Category = "Horror",
                    Title = "IT",
                    Year = 2017,
                    Rating = "R",
                    Edited = true,
                    Lent_To = null,
                    Notes = null
                },
                new AddMovieModel
                {
                    MovieId = 2,
                    Category = "Comedy",
                    Title = "Anchorman",
                    Year = 2004,
                    Rating = "PG-13",
                    Edited = true,
                    Lent_To = null,
                    Notes = null
                },
                new AddMovieModel
                {
                    MovieId = 3,
                    Category = "Action",
                    Title = "Top Gun",
                    Year = 1986,
                    Rating = "PG",
                    Edited = true,
                    Lent_To = null,
                    Notes = null
                }
                );
        }
    }
}
