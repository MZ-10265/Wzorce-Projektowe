using System.Globalization;

public sealed class DownloadServiceProxy : IDownloadService
{
    private readonly string _password;
    private readonly string _region;

    //Lazy initialization
    private DownloadService? _realService;

    public DownloadServiceProxy(string password, string region)
    {
        _password = password;
        _region = region;
    }

    public void Download(string fileName)
    {
        //Kontrola dostępu
        if (_password != "admin")
        {
            Console.WriteLine("Błędne hasło");
            return;
        }

        if (_region != "PL")
        {
            Console.WriteLine("Dostęp tylko w regionie PL");
            return;
        }

        //tworzymy prawdziwą usługę dopiero gdy potrzeba
        _realService ??= new DownloadService();

        // 3) Delegujemy wywołanie
        _realService.Download(fileName);
    }
}