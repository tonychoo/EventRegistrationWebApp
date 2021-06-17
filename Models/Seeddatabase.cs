using EventRegistrationWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace EventRegistrationWebApp.Models
{
    public class Seeddatabase
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EventRegistrationWebAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<EventRegistrationWebAppContext>>()))
            {
                // Seed only when database is empty
                if (context.Registration.Any())
                {
                    return;   // Database has been data
                }

                context.Registration.AddRange(
                    new Registration
                    {
                        Name = "Susan Lee",
                        Email = "susanlee123@host.com",
                        Gender = "F",
                        RegistrationDate = DateTime.Parse("2019-3-12"),
                        EventDays = @"[""Day 1"", ""Day 2""]",
                        AdditionalRequest = "I want to be seated at the 1st row if possible."
                    },

                    new Registration
                    {
                        Name = "Jack Pott",
                        Email = "pottyjacko@123.com",
                        Gender = "M",
                        RegistrationDate = DateTime.Parse("2019-4-12"),
                        EventDays = @"[""Day 2""]",
                        AdditionalRequest = "N /A"
                    },

                    new Registration
                    {
                        Name = "Mona Loot",
                        Email = "mloot3221@asknlearn.com",
                        Gender = "F",
                        RegistrationDate = DateTime.Parse("2019-5-12"),
                        EventDays = @"[""Day 1"", ""Day 2""]",
                        AdditionalRequest = ""
                    },

                    new Registration
                    {
                        Name = "Sonny Day",
                        Email = "sonnnny@liva.com",
                        Gender = "M",
                        RegistrationDate = DateTime.Parse("2019-3-12"),
                        EventDays = @"[""Day 1""]",
                        AdditionalRequest = "Seat behind Susan Lee is fine."
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
