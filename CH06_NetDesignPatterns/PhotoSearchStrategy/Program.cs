using System;
using System.Collections.Generic;
using System.Threading.Tasks;

internal class Program
{
    static async Task Main(string[] args)
    {
        List<IPhotoStrategy> strategies = new()
        {
            new Pexels(),
            new Pixabay(),
            new Redaction()
        };

        Console.WriteLine("=== Photo Search (Strategy pattern) ===");
        Console.WriteLine("Wybierz strategie wyszukiwania:");

        for (int i = 0; i < strategies.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {strategies[i].Name}");
        }

        Console.Write("Twoj wybor: ");
        string? choiceText = Console.ReadLine();

        if (!int.TryParse(choiceText, out int choice) ||
            choice < 1 || choice > strategies.Count)
        {
            Console.WriteLine("Niepoprawny wybor. Koniec programu.");
            return;
        }

        IPhotoStrategy selectedStrategy = strategies[choice - 1];

        Console.Write("Podaj fraze do wyszukania: ");
        string? query = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(query))
        {
            Console.WriteLine("Nie podano frazy. Koniec programu.");
            return;
        }

        Console.WriteLine();
        Console.WriteLine($"Uzyta strategia: {selectedStrategy.Name}");
        Console.WriteLine("Wyniki wyszukiwania:");

        try
        {
            List<string> results = await selectedStrategy.SearchAsync(query);

            if (results.Count == 0)
            {
                Console.WriteLine("Brak wynikow.");
            }
            else
            {
                foreach (string result in results)
                {
                    Console.WriteLine($"- {result}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wystapil blad podczas wyszukiwania:");
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine();
        Console.WriteLine("Nacisnij dowolny klawisz, aby zakonczyc...");
        Console.ReadKey();
    }
}
