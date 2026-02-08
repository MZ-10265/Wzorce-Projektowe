

public class Teacher
{
    private readonly List<Student> _students = new();

    public void Subscribe(Student student)
    {
        if (!_students.Contains(student))
        {
            _students.Add(student);
            Console.WriteLine($"Student {student.Name} zostal zapisany.");
        }
    }

    public void Unsubscribe(Student student)
    {
        if (_students.Remove(student))
        {
            Console.WriteLine($"Student {student.Name} zostal wypisany.");
        }
    }

    private void Notify(Result result)
    {
        foreach (var student in _students)
        {
            student.Update(result);
        }
    }

    public void PublishResult(string subject, string description)
    {
        Console.WriteLine($"\n[Nauczyciel] Publikuje informacje: {description}");
        var result = new Result(subject, description);
        Notify(result);
    }
}