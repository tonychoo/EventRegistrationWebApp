using Microsoft.EntityFrameworkCore;

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
