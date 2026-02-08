


public class Result
{
    public string Subject { get; }
    public string Description { get; }

    public Result(string subject, string description)
    {
        Subject = subject;
        Description = description;
    }

    public override string ToString()
    {
        return $"Przedmiot: {Subject}, Informacja: {Description}";
    }
}