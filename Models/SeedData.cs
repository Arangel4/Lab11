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
                    LastName = "Rangel",
                    Courses = new List<Course> {
                        new Course {Description = "CIDM 4490"},
                        new Course {Description = "MGT 1346"}
                    }
                },

                new Professor
                {
                    FirstName = "Alex",
                    LastName = "Tiroff",
                    Courses = new List<Course> {
                        new Course {Description = "CIDM 2340"}
                    }
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