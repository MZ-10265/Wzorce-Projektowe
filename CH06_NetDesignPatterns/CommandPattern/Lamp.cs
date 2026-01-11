using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Lamp
{
    private bool _isOn;

    public void TurnOn()
    {
        _isOn = true;
        Console.WriteLine("Lamp: ON");
    }

    public void TurnOff()
    {
        _isOn = false;
        Console.WriteLine("Lamp: OFF");
    }

    public string Status => _isOn ? "ON" : "OFF";
}