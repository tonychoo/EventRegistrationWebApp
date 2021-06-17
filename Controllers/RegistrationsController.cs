using EventRegistrationWebApp.Data;
using EventRegistrationWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace EventRegistrationWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationsController : ControllerBase
    {
        private readonly EventRegistrationWebAppContext _context;

        public RegistrationsController(EventRegistrationWebAppContext context)
        {
            _context = context;
        }

        // GET: api/Registrations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Registration>>> GetRegistration()
        {
            var reg = await _context.Registration.ToListAsync();

            foreach (var r in reg)
            {
                r.EventDays = string.Join(", ", JsonSerializer.Deserialize<IList<string>>(r.EventDays));

            }

            return reg;
        }
    }
}
