
ISystem windows = new SystemWindows();
ISystem linux = new SystemLinux();

//tworzymy abstrakcje (interfejsy UI) łącząc je z systemami (most / bridge)
IInterface consoleOnWindows = new ConsoleInterface(windows);
IInterface guiOnWindows = new GUIInterface(windows);

IInterface consoleOnLinux = new ConsoleInterface(linux);
IInterface guiOnLinux = new GUIInterface(linux);

//testujemy różne kombinacje
consoleOnWindows.Start();
consoleOnWindows.ShowMenu();
Console.WriteLine();

guiOnWindows.Start();
guiOnWindows.ShowMenu();
Console.WriteLine();

consoleOnLinux.Start();
consoleOnLinux.ShowMenu();
Console.WriteLine();

guiOnLinux.Start();
guiOnLinux.ShowMenu();