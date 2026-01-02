using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public sealed class ConsoleInterface : IInterface
{
    private readonly ISystem _system;

    public ConsoleInterface(ISystem system)
    {
        _system = system;
    }

    public void Start()
    {
        Console.WriteLine($"Start aplikacji w trybie CONSOLE na {_system.GetSystemName()}");
    }

    public void ShowMenu()
    {
        Console.WriteLine("Menu konsolowe:");
        Console.WriteLine("1. Start");
        Console.WriteLine("2. Exit");
    }
}