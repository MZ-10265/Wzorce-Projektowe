using System;

namespace CH01_CodeSmells_MZ.Solutions_MZ;

public static class Task06_DataClumps
{
    //obiekt grupujący powiązane dane
    public sealed class EventDetails
    {
        public string Name { get; }
        public DateTime Date { get; }
        public string Location { get; }

        public EventDetails(string name, DateTime date, string location)
        {
            Name = name;
            Date = date;
            Location = location;
        }
    }

    public sealed class EventService
    {
        public void RegisterEvent(EventDetails details)
        {
            Console.WriteLine($"Event: {details.Name}, Date: {details.Date:yyyy-MM-dd}, Location: {details.Location}");
        }
    }

    // TEST
    public static void Run()
    {
        Console.WriteLine("[06] Data Clumps");

        var service = new EventService();
        var details = new EventDetails("Hackathon", new DateTime(2026, 2, 1), "Warsaw");

        service.RegisterEvent(details);

        Console.WriteLine("Expected: one line with event name/date/location.");
    }
}
