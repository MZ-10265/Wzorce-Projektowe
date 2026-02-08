

var lamp = new Lamp();
var onCommand = new TurnOnCommand(lamp);
var offCommand = new TurnOffCommand(lamp);

var remote = new RemoteControl();
remote.SetButton(1, onCommand);
remote.SetButton(2, offCommand);

Console.WriteLine("Command");
Console.WriteLine("1 - ON");
Console.WriteLine("2 - OFF");
Console.WriteLine("0 - exit");

while (true)
{
    Console.Write($"Lamp status: {lamp.Status}. Choose: ");
    var input = Console.ReadLine();

    if (input == "0")
        break;

    if (int.TryParse(input, out int button))
        remote.Press(button);
    else
        Console.WriteLine("Wrong input.");
}

Console.WriteLine("End.");