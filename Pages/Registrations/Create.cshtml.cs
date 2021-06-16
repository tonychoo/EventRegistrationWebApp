using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EventRegistrationWebApp.Data;
using EventRegistrationWebApp.Models;

namespace EventRegistrationWebApp.Pages.Registrations
{
    public class CreateModel : PageModel
    {
        private readonly EventRegistrationWebApp.Data.EventRegistrationWebAppContext _context;

        public CreateModel(EventRegistrationWebApp.Data.EventRegistrationWebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Registration Registration { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Registration.Add(Registration);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
