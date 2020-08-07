using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Asp_.net_core.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Asp_net_coreContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Asp_net_coreContext>>()))
            {
                if (context.Movies.Any())
                {
                    return;   // DB has been seeded
                }
                context.Movies.AddRange(
                     new Movies
                     {
                         Title = "When Harry Met Sally",
                         ReleaseDate = DateTime.Parse("1989-2-12"),
                         Genre = "Romantic Comedy",
                         Price = 7.99M,
                         Rating = "R"
                     },
                      new Movies
                      {
                          Title = "Ghostbusters ",
                          ReleaseDate = DateTime.Parse("1984-3-13"),
                          Genre = "Comedy",
                          Rating = "R",
                          Price = 8.99M
                      },
                         new Movies
                         {
                             Title = "Ghostbusters 2",
                             ReleaseDate = DateTime.Parse("1986-2-23"),
                             Genre = "Comedy",
                             Rating = "R",
                             Price = 9.99M
                         },

                    new Movies
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Rating = "R",
                        Price = 3.99M
                    }
                    );
                context.SaveChanges();

            }
        }
    }
}
