using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventRegistrationWebApp.Models;

namespace EventRegistrationWebApp.Data
{
    public class EventRegistrationWebAppContext : DbContext
    {
        public EventRegistrationWebAppContext (DbContextOptions<EventRegistrationWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<EventRegistrationWebApp.Models.Registration> Registration { get; set; }
    }
}
