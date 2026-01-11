using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RemoteControl
{
    private readonly Dictionary<int, ICommand> _buttons = new();

    public void SetButton(int number, ICommand command)
    {
        _buttons[number] = command;
    }

    public void Press(int number)
    {
        if (_buttons.TryGetValue(number, out var cmd))
        {
            Console.WriteLine($"Executing: {cmd.Name}");
            cmd.Execute();
        }
        else
        {
            Console.WriteLine("No command on this button.");
        }
    }
}