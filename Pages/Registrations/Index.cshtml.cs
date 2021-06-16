using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EventRegistrationWebApp.Data;
using EventRegistrationWebApp.Models;

namespace EventRegistrationWebApp.Pages.Registrations
{
    public class IndexModel : PageModel
    {
        private readonly EventRegistrationWebApp.Data.EventRegistrationWebAppContext _context;

        public IndexModel(EventRegistrationWebApp.Data.EventRegistrationWebAppContext context)
        {
            _context = context;
        }

        public IList<Registration> Registration { get;set; }

        public async Task OnGetAsync()
        {
            Registration = await _context.Registration.ToListAsync();
        }
    }
}
