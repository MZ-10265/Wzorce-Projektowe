using System;

namespace CH01_CodeSmells_MZ.Solutions_MZ;

public static class Task04_RefusedBequest
{
    public interface IEmployee
    {
        void Work();
        void AttendMeeting();
    }
    public sealed class Manager : IEmployee
    {
        public void Work()
            => Console.WriteLine("Manager working.");

        public void AttendMeeting()
            => Console.WriteLine("Manager attending meeting.");

        public void ManageTeam()
            => Console.WriteLine("Managing team.");
    }

    // TEST
    public static void Run()
    {
        Console.WriteLine("[04] Refused Bequest");

        IEmployee employee = new Manager();
        employee.Work();
        employee.AttendMeeting();

        var manager = new Manager();
        manager.ManageTeam();

        Console.WriteLine("Expected: 3 lines about working/meeting/managing.");
    }
}
