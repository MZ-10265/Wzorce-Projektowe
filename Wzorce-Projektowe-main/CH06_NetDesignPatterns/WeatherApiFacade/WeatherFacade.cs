using Newtonsoft.Json.Linq;


public sealed class WeatherFacade
{
    private readonly HttpClient _http;
    private readonly string _apiKey;

    public WeatherFacade(HttpClient http, string apiKey)
    {
        _http = http;
        _apiKey = apiKey;
    }


    //Zwraca aktualną temperaturę w stopniach dla podanego miasta
    public async Task<double> GetCurrentTemperatureCAsync(string city)
    {
        if (string.IsNullOrWhiteSpace(city))
            throw new ArgumentException("Miasto nie może być puste.");

        string url =
            $"https://api.openweathermap.org/data/2.5/weather" +
            $"?q={Uri.EscapeDataString(city)}" +
            $"&appid={_apiKey}" +
            $"&units=metric";

        string json = await _http.GetStringAsync(url);

        JObject data = JObject.Parse(json);

        //wyciągamy: main.temp
        double temperature = data["main"]?["temp"]?.Value<double>()
            ?? throw new InvalidOperationException("Nie znaleziono temperatury w odpowiedzi API.");

        return temperature;
    }
}