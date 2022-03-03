using Portal.Shared.Models;

namespace Portal.Server.Services;

public interface ILocationService
{
    public List<Location> Locations { get; }

    public Location FindLocationBySlug(string slug);
}