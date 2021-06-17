using EventRegistrationWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EventRegistrationWebApp.Pages.Registrations
{
    public class CreateModel : PageModel
    {

        private readonly EventRegistrationWebApp.Data.EventRegistrationWebAppContext _context;

        [BindProperty]
        public List<string> SelectedEventDays { get; set; }

        [BindProperty]
        public List<SelectListItem> EventDays { get; set; }

        [BindProperty]
        public Registration Registration { get; set; }

        public CreateModel(EventRegistrationWebApp.Data.EventRegistrationWebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            EventDays = new List<SelectListItem>()
            {
                new SelectListItem() { Text="Day 1", Value="Day1" },
                new SelectListItem() { Text="Day 2", Value="Day2" },
                new SelectListItem() { Text="Day 3", Value="Day3" }
            };

            return Page();
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            for (int i = 0; i < EventDays.Count; i++)
            {
                if (EventDays[i].Selected== true)
                {
                    SelectedEventDays.Add(EventDays[i].Text);
                }
            }

            Registration.EventDays = JsonSerializer.Serialize(SelectedEventDays.ToArray());

            _context.Registration.Add(Registration);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
