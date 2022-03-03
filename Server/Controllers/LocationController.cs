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
        public async Task<IEnumerable<Location>> Get() => await _context.Locations.ToListAsync();

        [HttpGet("{slug}")]
        public async Task<Location> GetBySlug(string slug) => await _context.Locations.SingleAsync(l => l.Slug == slug);

        [HttpPost]
        public async Task<Location> Create([FromBody] Location location)
        {
            await _context.Locations.AddAsync(location);
            await _context.SaveChangesAsync();
            return location;
        }
    }
}
