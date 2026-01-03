using System.Net.Http.Headers;
using System.Text.Json;

public sealed class Pexels : IPhotoStrategy
{
    public string Name => "Pexels";

    public async Task<List<string>> SearchAsync(string query)
    {
        if (string.IsNullOrWhiteSpace(ApiKeys.Pexels))
            return new List<string> { "Brak klucza Pexels API." };

        using var http = new HttpClient();
        http.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue(ApiKeys.Pexels);

        var url =
            $"https://api.pexels.com/v1/search?query={Uri.EscapeDataString(query)}&per_page=5";

        var json = await http.GetStringAsync(url);

        using var doc = JsonDocument.Parse(json);
        var results = new List<string>();

        foreach (var photo in doc.RootElement.GetProperty("photos").EnumerateArray())
        {
            if (photo.TryGetProperty("src", out var src) &&
                src.TryGetProperty("original", out var original))
            {
                results.Add(original.GetString() ?? "");
            }
        }

        return results;
    }
}
