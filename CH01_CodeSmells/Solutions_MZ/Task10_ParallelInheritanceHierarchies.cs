using System;

namespace Solutions_MZ;

public static class Task10_ParallelInheritanceHierarchies
{
    //interfejs zamiast BaseLogger
    public interface ILogger
    {
        void LogMessage(string message);
    }

    public sealed class FileLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"[FILE] {message}");
        }
    }

    public sealed class DatabaseLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"[DB] {message}");
        }
    }

    //interfejs zamiast BaseExporter
    public interface IExporter
    {
        void ExportData(string payload);
    }

    public sealed class XmlExporter : IExporter
    {
        public void ExportData(string payload)
        {
            Console.WriteLine($"<xml>{payload}</xml>");
        }
    }

    public sealed class JsonExporter : IExporter
    {
        public void ExportData(string payload)
        {
            Console.WriteLine($"{{ \"data\": \"{payload}\" }}");
        }
    }

    //klasa używająca interfejsów
    public sealed class DataPipeline
    {
        private readonly ILogger _logger;
        private readonly IExporter _exporter;

        public DataPipeline(ILogger logger, IExporter exporter)
        {
            _logger = logger;
            _exporter = exporter;
        }

        public void Run(string payload)
        {
            _logger.LogMessage("Starting export...");
            _exporter.ExportData(payload);
            _logger.LogMessage("Export finished.");
        }
    }

    public static void Run()
    {
        Console.WriteLine("[10] Parallel Inheritance Hierarchies");

        var pipeline1 = new DataPipeline(new FileLogger(), new XmlExporter());
        pipeline1.Run("Hello");

        var pipeline2 = new DataPipeline(new DatabaseLogger(), new JsonExporter());
        pipeline2.Run("World");

        Console.WriteLine("Expected: two runs with different logger/exporter combos.");
    }
}
