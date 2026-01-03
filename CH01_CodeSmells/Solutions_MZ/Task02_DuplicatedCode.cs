using System;

namespace CH01_CodeSmells_MZ.Solutions_MZ;

public static class Task02_DuplicatedCode
{
    public enum LogLevel
    {
        Error,
        Warning
    }

    public sealed class Logger
    {
        //wspólna logika wyodrębniona do metody
        private string FormatLogMessage(LogLevel level, string message, DateTime timestamp)
        {
            return $"{level.ToString().ToUpper()}: [{timestamp:yyyy-MM-dd HH:mm:ss}] {message}";
        }

        public void LogError(string message, DateTime timestamp)
            => Console.WriteLine(FormatLogMessage(LogLevel.Error, message, timestamp));

        public void LogWarning(string message, DateTime timestamp)
            => Console.WriteLine(FormatLogMessage(LogLevel.Warning, message, timestamp));
    }

    // TEST
    public static void Run()
    {
        Console.WriteLine("[02] Duplicated Code");

        var logger = new Logger();
        logger.LogError("Disk not found", new DateTime(2026, 1, 3, 12, 0, 0));
        logger.LogWarning("Low memory", new DateTime(2026, 1, 3, 12, 1, 0));

        Console.WriteLine("Expected: two lines, one ERROR and one WARNING, with timestamps.");
    }
}
