using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portal.Server.Data;

namespace Portal.Server.Controllers;

[Controller]
[Route("")]
public class HomeController : Controller
{
    private readonly PortalContext _context;

    public HomeController(PortalContext context) => _context = context;
    
    [HttpGet("{slug}")]
    public async Task<IActionResult> Get(string slug)
    {
        try
        {
            var location = await _context.Locations.SingleAsync(l => l.Slug == slug);
            return Redirect(location.Address);
        }
        catch (Exception e)
        {
            return NotFound();
        }
    }
}