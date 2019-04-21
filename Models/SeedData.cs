using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab11.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LabDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LabDbContext>>()))
            {
                if (context.Professor.Any())
                {
                    return;
                }

            context.Professor.AddRange(
                new Professor
                {
                    FirstName = "Ariana",
                    LastName = "Rangel"
                },

                new Professor
                {
                    FirstName = "Alex",
                    LastName = "Tiroff"
                },

                new Professor
                {
                    FirstName = "Becca",
                    LastName = "Gonzalez"
                }
            ); 
            context.SaveChanges();    
            }
        }
    }
}