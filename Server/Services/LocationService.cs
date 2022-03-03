using Portal.Shared.Models;

namespace Portal.Server.Services;

public class LocationService : ILocationService
{
    private readonly List<Location> _locations = new()
    {
        new()
        {
            Id = 1,
            Slug = "jellyfin",
            Host = "http://127.0.0.1:8096",
            Icon = "",
            Name = "Jellyfin",
            Description = "Jellyfin",
        },
        new()
        {
            Id = 2,
            Slug = "qbittorrent",
            Host = "http://127.0.0.1:8080",
            Icon = "",
            Name = "qBittorrent",
            Description = "qBittorrent",
        },
        new()
        {
            Id = 3,
            Slug = "radarr",
            Host = "http://127.0.0.1:7878",
            Icon = "",
            Name = "Radarr",
            Description = "Radarr",
        },
        new()
        {
            Id = 4,
            Slug = "sonarr",
            Host = "http://127.0.0.1:8989",
            Icon = "",
            Name = "Sonarr",
            Description = "Sonarr",
        },
        new()
        {
            Id = 5,
            Slug = "prowlarr",
            Host = "http://127.0.0.1:9696",
            Icon = "",
            Name = "Prowlarr",
            Description = "Prowlarr",
        },
        new()
        {
            Id = 6,
            Slug = "ombi",
            Host = "http://127.0.0.1:9696",
            Icon = "",
            Name = "Ombi",
            Description = "Ombi",
        }
    };

    public List<Location> Locations => _locations;

    public Location FindLocationById(int id) => _locations.Single(l => l.Id == id);
    
    public Location FindLocationBySlug(string slug) => _locations.Single(l => l.Slug == slug);
}