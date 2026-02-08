using Newtonsoft.Json;

var rng = new Random();

// prototyp
var prototype = new Ork
{
    Age = 30,
    Strenght = 10,
    Speed = 5
};

Console.WriteLine("PROTOTYP (bazowy ork):");
Console.WriteLine(prototype);
Console.WriteLine();

//klony
var clones = new List<Ork>();

for (int i = 1; i <= 10; i++)
{
    Ork clone = prototype.copyOrk();

    // modyfikacja
    clone.Age += rng.Next(-3, 4);        
    clone.Strenght += rng.Next(-2, 6);   
    clone.Speed += rng.Next(-1, 3);      
    clones.Add(clone);
}

Console.WriteLine("KLONY (kopie prototypu):");
int index = 1;
foreach (var c in clones)
{
    Console.WriteLine($"{index++}. {c}");
}

Console.WriteLine();
Console.WriteLine("KONTROLA: prototyp powinien pozostać bez zmian:");
Console.WriteLine(prototype);