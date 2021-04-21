using AdvancedProgramming_Lesson2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace AdvancedProgramming_Lesson2.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>());
            // Look for any movies.
            if (context.Movie.Any())
            {
                return; // DB has been seeded
            }
            context.Movie.AddRange(
            new Movie
            {
                Title = "FILM1",
                ReleaseDate = DateTime.Parse("2023-12-21"),
                Genre = "Some shit",
                Price = 7.23M,
                Country = "Polska",
                Lenght = 2
            },
            new Movie
            {
                Title = "Ghostbusters ",
                ReleaseDate = DateTime.Parse("1984-3-13"),
                Genre = "Comedy",
                Price = 8.99M,
                Country = "Niemcy",
                Lenght = 1
            },
            new Movie
            {
                Title = "Ghostbusters 2",
                ReleaseDate = DateTime.Parse("1986-2-23"),
                Genre = "Comedy",
                Price = 9.99M,
                Country = "Hiszpania",
                Lenght = 1
            },
            new Movie
            {
                Title = "Rio Bravo",
                ReleaseDate = DateTime.Parse("1959-4-15"),
                Genre = "Western",
                Price = 3.99M,
                Country = "Czechy",
                Lenght = 1
            }
            );
            context.SaveChanges();
        }
    }
}
