using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TileType
{
    public string Name { get; }
    public char Symbol { get; }

    public TileType(string name, char symbol)
    {
        Name = name;
        Symbol = symbol;
    }
}