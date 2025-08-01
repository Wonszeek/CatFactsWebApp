using System.Text.Json;

namespace CatFactsWebApp.Services;

public class CatFactService : ICatFactService
{
    private readonly HttpClient _httpClient;

    public CatFactService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> GetCatFactAsync()
    {
        var response = await _httpClient.GetAsync("https://catfact.ninja/fact");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        using var doc = JsonDocument.Parse(content);
        return doc.RootElement.GetProperty("fact").GetString()!;
    }
}
