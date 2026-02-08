using System;

namespace Solutions_MZ;

public static class Task21_LazyClass
{
    public sealed class MessagingService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Notification sent: {message}");
        }
    }

    //klasa NotificationSender usunięta
    public static void Run()
    {
        Console.WriteLine("[21] Lazy Class");

        var messaging = new MessagingService();
        messaging.SendNotification("Build completed");

        Console.WriteLine("Expected: Notification sent: Build completed");
    }
}
