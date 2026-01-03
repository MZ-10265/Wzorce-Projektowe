using System;

namespace Solutions_MZ;

public static class Task07_InappropriateIntimacy
{
    public sealed class Course
    {
        public int Credits { get; private set; }
        public bool IsCompleted { get; private set; }

        //publiczna metoda zmiany stanu zamiast grzebania w setterach
        public void Complete(int credits)
        {
            if (credits <= 0) throw new ArgumentOutOfRangeException(nameof(credits));

            Credits = credits;
            IsCompleted = true;
        }
    }

    public sealed class Student
    {
        //student nie dotyka pól/setterów Course bezpośrednio
        public void CompleteCourse(Course course)
        {
            if (course is null) throw new ArgumentNullException(nameof(course));
            course.Complete(credits: 3);
        }
    }

    public static void Run()
    {
        Console.WriteLine("[07] Inappropriate Intimacy");

        var student = new Student();
        var course = new Course();

        student.CompleteCourse(course);

        Console.WriteLine($"Course completed: {course.IsCompleted}, credits: {course.Credits}");
        Console.WriteLine("Expected: completed=True, credits=3");
    }
}
