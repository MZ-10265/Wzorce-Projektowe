



Console.WriteLine("Czy dziecko było grzeczne? (y/n)");
var input = Console.ReadLine();

bool isGoodChild = input?.ToLower() == "y";

var elf = new Elf();
Toy toy = elf.PrepareToy(isGoodChild);

Console.WriteLine($"Stworzono zabawkę: {toy.Name}");