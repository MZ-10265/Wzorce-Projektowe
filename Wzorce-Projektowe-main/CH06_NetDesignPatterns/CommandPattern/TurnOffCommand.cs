using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TurnOffCommand : ICommand
{
    private readonly Lamp _lamp;
    public string Name => "Turn OFF";

    public TurnOffCommand(Lamp lamp)
    {
        _lamp = lamp;
    }

    public void Execute()
    {
        _lamp.TurnOff();
    }
}