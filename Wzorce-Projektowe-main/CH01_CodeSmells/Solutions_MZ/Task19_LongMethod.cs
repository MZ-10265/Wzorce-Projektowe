using System;

namespace Solutions_MZ;

public static class Task19_LongMethod
{
    public sealed class GradeBook
    {
        public int Grade { get; private set; }
        public bool IsFinalized { get; private set; }

        public void SetGrade(int grade)
        {
            if (grade < 0 || grade > 100) throw new ArgumentOutOfRangeException(nameof(grade));
            if (IsFinalized) throw new InvalidOperationException("GradeBook is finalized.");

            Grade = grade;
        }

        public void FinalizeGrades()
        {
            if (IsFinalized) return;
            IsFinalized = true;
        }
    }

    public sealed class Teacher
    {
        //teacher nie dotyka setterów/pól bezpośrednio
        public void FinalizeGrades(GradeBook gradeBook)
        {
            if (gradeBook is null) throw new ArgumentNullException(nameof(gradeBook));

            gradeBook.SetGrade(90);
            gradeBook.FinalizeGrades();
        }
    }

    public static void Run()
    {
        Console.WriteLine("[19] Long Method (encapsulation in GradeBook)");

        var gradeBook = new GradeBook();
        var teacher = new Teacher();

        teacher.FinalizeGrades(gradeBook);

        Console.WriteLine($"Grade: {gradeBook.Grade}, Finalized: {gradeBook.IsFinalized}");
        Console.WriteLine("Expected: Grade=90, Finalized=True");
    }
}
