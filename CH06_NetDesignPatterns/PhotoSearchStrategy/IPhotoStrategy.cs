
public interface IPhotoStrategy
{
    string Name { get; }

    Task<List<string>> SearchAsync(string query);
}