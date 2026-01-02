using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public sealed class DownloadService : IDownloadService
{
    public void Download(string fileName)
    {
        Console.WriteLine($"⬇️ Pobieranie pliku: {fileName}");
        Thread.Sleep(1000); // symulacja
        Console.WriteLine("✅ Pobieranie zakończone");
    }
}