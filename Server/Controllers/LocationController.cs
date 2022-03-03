using Microsoft.AspNetCore.Mvc;
using Portal.Server.Services;
using Portal.Shared;
using Portal.Shared.Models;

namespace Portal.Server.Controllers
{
    [ApiController]
    [Route("api/locations")]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;
        private readonly ILogger<LocationController> _logger;

        public LocationController(ILocationService locationService, ILogger<LocationController> logger)
        {
            _locationService = locationService;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Location> Get() => _locationService.Locations;
        
        [HttpGet("{slug}")]
        public Location GetBySlug(string slug) => _locationService.FindLocationBySlug(slug);
    }
}
