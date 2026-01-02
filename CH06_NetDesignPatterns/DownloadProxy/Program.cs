

Console.Write("Podaj hasło: ");
string? password = Console.ReadLine();

Console.Write("Podaj region (np. PL): ");
string? region = Console.ReadLine();

Console.Write("Podaj nazwę pliku: ");
string? fileName = Console.ReadLine();


IDownloadService service =
    new DownloadServiceProxy(password ?? "", region ?? "");

service.Download(fileName ?? "file.txt");