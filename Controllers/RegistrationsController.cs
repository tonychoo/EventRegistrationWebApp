using EventRegistrationWebApp.Data;
using EventRegistrationWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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
            return await _context.Registration.ToListAsync();
        }

        private bool RegistrationExists(int id)
        {
            return _context.Registration.Any(e => e.ID == id);
        }
    }
}
