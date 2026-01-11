using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TileTypeFactory
{
    private readonly Dictionary<string, TileType> _cache = new();

    public TileType Get(string key)
    {
        if (_cache.TryGetValue(key, out var existing))
            return existing;

        // Tworzymy typ tylko raz (pierwsze zapotrzebowanie)
        TileType created = key switch
        {
            "grass" => new TileType("Trawa", '.'),
            "water" => new TileType("Woda", '~'),
            "road" => new TileType("Droga", '#'),
            _ => new TileType("Inne", '?')
        };

        _cache[key] = created;
        return created;
    }

    public int Count => _cache.Count;
}
