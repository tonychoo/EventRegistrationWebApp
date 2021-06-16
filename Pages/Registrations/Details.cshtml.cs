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
    public class DetailsModel : PageModel
    {
        private readonly EventRegistrationWebApp.Data.EventRegistrationWebAppContext _context;

        public DetailsModel(EventRegistrationWebApp.Data.EventRegistrationWebAppContext context)
        {
            _context = context;
        }

        public Registration Registration { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Registration = await _context.Registration.FirstOrDefaultAsync(m => m.ID == id);

            if (Registration == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
