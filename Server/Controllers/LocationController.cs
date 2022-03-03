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
        private readonly ILogger<WeatherForecastController> _logger;

        public LocationController(ILocationService locationService, ILogger<WeatherForecastController> logger)
        {
            _locationService = locationService;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Location> Get() => _locationService.Locations;

        [HttpGet("{id:int}")]
        public Location GetById(int id)
        {
            _logger.LogInformation("Id is {Id}", id);
            return _locationService.FindLocationById(id);
        }

        [HttpGet("{slug}")]
        public Location GetBySlug(string slug) => _locationService.FindLocationBySlug(slug);
    }
}
