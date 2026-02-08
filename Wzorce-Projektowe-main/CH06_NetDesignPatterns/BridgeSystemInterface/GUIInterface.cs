using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public sealed class GUIInterface : IInterface
{
    private readonly ISystem _system;

    public GUIInterface(ISystem system)
    {
        _system = system;
    }

    public void Start()
    {
        Console.WriteLine($"Start aplikacji w trybie GUI na {_system.GetSystemName()}");
    }

    public void ShowMenu()
    {
        Console.WriteLine("Menu graficzne:");
        Console.WriteLine("[ START ]  [ EXIT ]");
    }
}