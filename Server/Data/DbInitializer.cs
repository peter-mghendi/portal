using Microsoft.EntityFrameworkCore;
using Portal.Shared.Models;

namespace Portal.Server.Data;

public class DbInitializer
{
    private static readonly List<(string Name, string Address)> Data = new()
    {
        ("Jellyfin", "http://127.0.0.1:8096"),
        ("qBittorrent", "http://127.0.0.1:8080"),
        ("Radarr", "http://127.0.0.1:7878"),
        ("Sonarr", "http://127.0.0.1:8989"),
        ("Lidarr", "lidarr"),
        ("Readarr", "http://127.0.0.1:8787"),
        ("Prowlarr", "http://127.0.0.1:9696"),
        ("Ombi", "http://127.0.0.1:5000"),
    };

    
    public static async Task InitializeAsync(PortalContext context)
    {
        if (await context.Locations.AnyAsync()) return;

        var description = "This is is some long text meant to be a sample description for this app, click below to visit!";
        var locations = Data.Select(item => new Location()
        {
            Name = item.Name,
            Slug = item.Name.ToLower(),
            Icon = string.Empty,
            Address = item.Address,
            Description = description
        });

        await context.AddRangeAsync(locations);
        await context.SaveChangesAsync();
    }
}