using Flurl;
using Flurl.Http;
using Portal.Shared.Models;

namespace Portal.Client.Services;

public class LocationClient
{
    private readonly string _baseAddress;
    
    public LocationClient(string host) => _baseAddress = $"{host}api/locations";

    public async Task<List<Location>> FetchLocationsAsync(CancellationToken cancellationToken = default) =>
        await _baseAddress.GetJsonAsync<List<Location>>(cancellationToken);

    public async Task<Location> FetchLocationByIdAsync(string slug, CancellationToken cancellationToken = default) =>
        await _baseAddress.AppendPathSegment(slug).GetJsonAsync<Location>(cancellationToken);
}