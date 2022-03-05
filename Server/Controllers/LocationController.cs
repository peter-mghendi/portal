using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portal.Server.Data;
using Portal.Shared.Models;

namespace Portal.Server.Controllers
{
    [ApiController]
    [Route("api/locations")]
    public class LocationController : ControllerBase
    {
        private readonly PortalContext _context;
        private readonly ILogger<LocationController> _logger;

        public LocationController(ILogger<LocationController> logger, PortalContext context)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Location>>> Get() => await _context.Locations.ToListAsync();

        [HttpGet("{slug}")]
        public async Task<ActionResult<Location>> GetBySlug(string slug)
        {
            try
            {
                return await _context.Locations.SingleAsync(l => l.Slug == slug);
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<ActionResult<Location>> Create([FromBody] Location location)
        {
            await _context.Locations.AddAsync(location);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBySlug), new { slug = location.Slug }, location);
        }
    }
}
