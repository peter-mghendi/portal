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
            Name = "Jellyfin",
            Slug = "jellyfin",
            Icon = "",
            Address = "http://127.0.0.1:8096",
            Description = Description,
        },
        new()
        {
            Id = 2,
            Name = "qBittorrent",
            Slug = "qbittorrent",
            Icon = "",
            Address = "http://127.0.0.1:8080",
            Description = Description,
        },
        new()
        {
            Id = 3,
            Name = "Radarr",
            Slug = "radarr",
            Icon = "",
            Address = "http://127.0.0.1:7878",
            Description = Description,
        },
        new()
        {
            Id = 4,
            Name = "Sonarr",
            Slug = "sonarr",
            Icon = "",
            Address = "http://127.0.0.1:8989",
            Description = Description,
        },
        new()
        {
            Id = 5,
            Name = "Lidarr",
            Slug = "lidarr",
            Icon = "",
            Address = "http://127.0.0.1:8686",
            Description = Description,
        },
        new()
        {
            Id = 6,
            Name = "Readarr",
            Slug = "readarr",
            Icon = "",
            Address = "http://127.0.0.1:8787",
            Description = Description,
        },
        new()
        {
            Id = 7,
            Name = "Prowlarr",
            Slug = "prowlarr",
            Icon = "",
            Address = "http://127.0.0.1:9696",
            Description =  Description,
        },
        new()
        {
            Id = 8,
            Name = "Ombi",
            Slug = "ombi",
            Icon = "",
            Address = "http://127.0.0.1:5000",
            Description = Description,
        }
    };

    public List<Location> Locations => _locations;

    public Location FindLocationBySlug(string slug) => _locations.Single(l => l.Slug == slug);
}