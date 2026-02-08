
Console.WriteLine("=== Weather API – Facade ===");

//pobranie API key
string? apiKey = Environment.GetEnvironmentVariable("OPENWEATHER_API_KEY");

if (string.IsNullOrWhiteSpace(apiKey))
{
    Console.Write("Podaj OpenWeather API Key: ");  //9154ca851b799eb267f482de4c135b7e
    //1d21929cc38e2dad8425d0ce0932e210
    apiKey = Console.ReadLine();
}

if (string.IsNullOrWhiteSpace(apiKey))
{
    Console.WriteLine("Brak API key. Koniec programu.");
    return;
}

//Pobranie miasta
Console.Write("Podaj miasto (np. Warsaw): ");
string? city = Console.ReadLine();

if (string.IsNullOrWhiteSpace(city))
{
    Console.WriteLine("Nie podano miasta. Koniec programu.");
    return;
}

using var http = new HttpClient();

// Tworzymy fasade
var facade = new WeatherFacade(http, apiKey);

try
{
    double temp = await facade.GetCurrentTemperatureCAsync(city);
    Console.WriteLine($"Aktualna temperatura w {city}: {temp:0.0} °C");
}
catch (Exception ex)
{
    Console.WriteLine($"Błąd: {ex.Message}");
}