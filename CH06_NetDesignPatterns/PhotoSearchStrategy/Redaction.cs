public sealed class Redaction : IPhotoStrategy
{
    public string Name => "Redaction (top 2 from Pixabay)";

    public async Task<List<string>> SearchAsync(string query)
    {
        var baseStrategy = new Pixabay();
        var results = await baseStrategy.SearchAsync(query);

        if (results.Count == 1 && results[0].StartsWith("Brak "))
            return results;

        return results.Take(2).ToList();
    }
}
