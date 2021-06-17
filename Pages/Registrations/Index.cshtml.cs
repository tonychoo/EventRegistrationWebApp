using EventRegistrationWebApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventRegistrationWebApp.Pages.Registrations
{
    public class IndexModel : PageModel
    {
        private readonly EventRegistrationWebApp.Data.EventRegistrationWebAppContext _context;

        public IndexModel(EventRegistrationWebApp.Data.EventRegistrationWebAppContext context)
        {
            _context = context;
        }

        public IList<Registration> Registration { get; set; }

        public async Task OnGetAsync()
        {
            Registration = await _context.Registration.ToListAsync();
        }
    }
}
