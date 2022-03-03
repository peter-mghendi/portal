using Portal.Shared.Models;

namespace Portal.Server.Services;

public class LocationService : ILocationService
{
    private const string Description =
        "This is is some long text meant to be a sample description for this app, click below to visit!";
    private readonly List<Location> _locations = new()
    {
        new()
        {
            Id = 1,
            Slug = "jellyfin",
            Icon = "",
            Name = "Jellyfin",
            Address = "http://127.0.0.1:8096",
            Description = Description,
        },
        new()
        {
            Id = 2,
            Slug = "qbittorrent",
            Icon = "",
            Name = "qBittorrent",
            Address = "http://127.0.0.1:8080",
            Description = Description,
        },
        new()
        {
            Id = 3,
            Slug = "radarr",
            Icon = "",
            Name = "Radarr",
            Address = "http://127.0.0.1:7878",
            Description = Description,
        },
        new()
        {
            Id = 4,
            Slug = "sonarr",
            Icon = "",
            Name = "Sonarr",
            Address = "http://127.0.0.1:8989",
            Description = Description,
        },
        new()
        {
            Id = 5,
            Slug = "lidarr",
            Icon = "",
            Name = "Lidarr",
            Address = "http://127.0.0.1:8686",
            Description = Description,
        },
        new()
        {
            Id = 6,
            Slug = "readarr",
            Icon = "",
            Name = "Readarr",
            Address = "http://127.0.0.1:8787",
            Description = Description,
        },
        new()
        {
            Id = 7,
            Slug = "prowlarr",
            Icon = "",
            Name = "Prowlarr",
            Address = "http://127.0.0.1:9696",
            Description =  Description,
        },
        new()
        {
            Id = 8,
            Slug = "ombi",
            Icon = "",
            Name = "Ombi",
            Address = "http://127.0.0.1:5000",
            Description = Description,
        }
    };

    public List<Location> Locations => _locations;

    public Location FindLocationBySlug(string slug) => _locations.Single(l => l.Slug == slug);
}