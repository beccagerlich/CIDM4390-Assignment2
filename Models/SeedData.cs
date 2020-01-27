using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Assignment2.Data;
using System;
using System.Linq;

namespace Assignment2.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ClubContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ClubContext>>()))
            {
                // Look for any movies.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Student.AddRange(
                    new Student
                    {
                        FName = "Becca",
                        LName = "Gerlich",
                        Skills = "HTML, CSS, JavaScript"
                    },

                    new Student
                    {
                        FName = "Nga",
                        LName = "Nguyen",
                        Skills = "C#, Console, SQL"
                    },

                    new Student
                    {
                        FName = "Amy",
                        LName = "Saysouriosak",
                        Skills = "React, CSS, Photoshop"
                    }
                );
                if (context.Client.Any())
                {
                    return;   // DB has been seeded
                }

                context.Client.AddRange(
                    new Client
                    {
                        CName = "Computer Services Inc.",
                        DueDate = DateTime.Parse("2020-12-10"),
                        Description = "A web app that allows users to add, delete, or edit information in a database for a help glossery"
                    },

                    new Client
                    {
                        CName = "Dominos",
                        DueDate = DateTime.Parse("2021-4-23"),
                        Description = "A mobile application for pizza dilivery"
                    },

                    new Client
                    {
                        CName = "John Doe",
                        DueDate = DateTime.Parse("2023-1-1"),
                        Description = "A mobile app for my online business"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}