using System;

namespace Solutions_MZ;

public static class Task20_SpeculativeGenerality
{
    public sealed class HttpRequest
    {
        public string Url { get; }
        public HttpRequest(string url) => Url = url;
    }

    public sealed class FileRequest
    {
        public string FileName { get; }
        public FileRequest(string fileName) => FileName = fileName;
    }

    public sealed class AdvancedHandler
    {
        public void HandleHttpRequest(HttpRequest request)
        {
            Console.WriteLine($"Handling HTTP request: {request.Url}");
        }

        public void HandleFileRequest(FileRequest request)
        {
            Console.WriteLine($"Handling file request: {request.FileName}");
        }
    }

    public static void Run()
    {
        Console.WriteLine("[20] Speculative Generality");

        var handler = new AdvancedHandler();
        handler.HandleHttpRequest(new HttpRequest("https://example.com"));
        handler.HandleFileRequest(new FileRequest("report.pdf"));

        Console.WriteLine("Expected: HTTP handled + File handled");
    }
}
