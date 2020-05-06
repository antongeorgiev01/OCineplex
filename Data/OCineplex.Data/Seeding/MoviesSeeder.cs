namespace OCineplex.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using OCineplex.Data.Models;

    public class MoviesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Movies.Any())
            {
                return;
            }

            await dbContext.Movies.AddAsync(new Movie
            {
                Title = "Avengers",
                Director = "Joss Whedon",
                Duration = new TimeSpan(2, 23, 0),
                Genre = Genre.SuperHero,
                Rating = 8.00,
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDYxNjQyMjAtNTdiOS00NGYwLWFmNTAtNThmYjU5ZGI2YTI1XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_SY1000_CR0,0,675,1000_AL_.jpg",
            });

            await dbContext.Movies.AddAsync(new Movie
            {
                Title = "Guardians of the Galaxy",
                Director = "James Gunn",
                Duration = new TimeSpan(2, 1, 0),
                Genre = Genre.SuperHero,
                Rating = 8.00,
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTAwMjU5OTgxNjZeQTJeQWpwZ15BbWU4MDUxNDYxODEx._V1_SY1000_CR0,0,674,1000_AL_.jpg",
            });
        }
    }
}
