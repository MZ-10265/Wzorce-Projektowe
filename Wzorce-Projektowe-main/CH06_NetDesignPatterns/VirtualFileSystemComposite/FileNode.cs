using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public sealed class FileNode : INode
{
    public string Name { get; }
    private readonly int _size;

    public FileNode(string name, int size)
    {
        Name = name;
        _size = size;
    }

    public int GetSize()
    {
        //Dla liścia rozmiar jest własny
        return _size;
    }

    public void Print(string indent = "")
    {
        Console.WriteLine($"{indent}-  {Name} ({_size} KB)");
    }
}