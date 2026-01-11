


Console.WriteLine("Flyweight (Pylek) - Mapa kafelkow");

var factory = new TileTypeFactory();

int width = 30;
int height = 10;

var rand = new Random();

string[] keys = { "grass", "grass", "grass", "road", "water" };

var map = new Tile[height, width];

for (int y = 0; y < height; y++)
{
    for (int x = 0; x < width; x++)
    {
        string key = keys[rand.Next(keys.Length)];
        TileType type = factory.Get(key);
        map[y, x] = new Tile(x, y, type);
    }
}

//wypis mapy(symbole)
Console.WriteLine("\nMapa:");
for (int y = 0; y < height; y++)
{
    for (int x = 0; x < width; x++)
        Console.Write(map[y, x].Type.Symbol);

    Console.WriteLine();
}

//duzo kafelkow, malo typow
Console.WriteLine("\nStatystyki:");
Console.WriteLine($"Liczba pol (Tile): {width * height}");
Console.WriteLine($"Liczba typow (TileType - flyweight): {factory.Count}");
Console.WriteLine("\nKoniec.");