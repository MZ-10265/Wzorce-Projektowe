using System;

namespace Solutions_MZ;

public static class Task08_LongMessageChain
{
    public sealed class School
    {
        private readonly Classroom _classroom = new Classroom();

        public Classroom GetClassroom() => _classroom;

        //metoda delegująca skracająca łańcuch
        public string GetTeacherName()
        {
            return _classroom.GetTeacher().GetName();
        }
    }

    public sealed class Classroom
    {
        private readonly Teacher _teacher = new Teacher();

        public Teacher GetTeacher() => _teacher;
    }

    public sealed class Teacher
    {
        public string GetName() => "Jan Nowak";
    }

    public static void Run()
    {
        Console.WriteLine("[08] Long Message Chain");

        var school = new School();

        string teacherName = school.GetTeacherName();

        Console.WriteLine($"Teacher: {teacherName}");
        Console.WriteLine("Expected: Teacher: Jan Nowak");
    }
}
