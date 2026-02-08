using System.Text.Json;

public sealed class Pixabay : IPhotoStrategy
{
    public string Name => "Pixabay";

    public async Task<List<string>> SearchAsync(string query)
    {
        if (string.IsNullOrWhiteSpace(ApiKeys.Pixabay))
            return new List<string> { "Brak klucza Pixabay API." };

        using var http = new HttpClient();

        var url =
            $"https://pixabay.com/api/?key={ApiKeys.Pixabay}" +
            $"&q={Uri.EscapeDataString(query)}&image_type=photo&per_page=5";

        var json = await http.GetStringAsync(url);

        using var doc = JsonDocument.Parse(json);
        var results = new List<string>();

        foreach (var hit in doc.RootElement.GetProperty("hits").EnumerateArray())
        {
            if (hit.TryGetProperty("largeImageURL", out var large))
                results.Add(large.GetString() ?? "");
        }

        return results;
    }
}
