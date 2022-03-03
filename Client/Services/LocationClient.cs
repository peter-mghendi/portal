using Flurl;
using Flurl.Http;
using Portal.Shared.Models;

namespace Portal.Client.Services;

public class LocationClient
{
    private readonly string _baseAddress;
    
    public LocationClient(string host) => _baseAddress = $"{host}api/locations";

    public async Task<Location> CreateLocationAsync(Location location, CancellationToken cancellationToken = default) =>
        await _baseAddress.PostJsonAsync(location, cancellationToken).ReceiveJson<Location>();

    public async Task<List<Location>> FetchLocationsAsync(CancellationToken cancellationToken = default) =>
        await _baseAddress.GetJsonAsync<List<Location>>(cancellationToken);

    public async Task<Location> FetchLocationBySlugAsync(string slug, CancellationToken cancellationToken = default) =>
        await _baseAddress.AppendPathSegment(slug).GetJsonAsync<Location>(cancellationToken);
}