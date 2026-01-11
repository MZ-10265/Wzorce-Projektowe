
public class Student
{
    public string Name { get; }

    public Student(string name)
    {
        Name = name;
    }

    public void Update(Result result)
    {
        Console.WriteLine($"[Student: {Name}] Otrzymano powiadomienie -> {result}");
    }
}