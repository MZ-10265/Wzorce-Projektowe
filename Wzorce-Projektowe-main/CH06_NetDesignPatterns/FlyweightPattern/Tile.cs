using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tile
{
    public int X { get; }
    public int Y { get; }
    public TileType Type { get; }

    public Tile(int x, int y, TileType type)
    {
        X = x;
        Y = y;
        Type = type;
    }
}