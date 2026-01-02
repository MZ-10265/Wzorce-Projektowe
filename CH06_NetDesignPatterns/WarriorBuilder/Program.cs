
WarriorPost BuildWarrior(WarriorBuilder builder, string type)
{
    // Zaczynamy budowę nowego wojownika
    builder.CreateNew(type);
    // zapis
    builder.Register();
    // broń
    builder.GiveWeapon();
    // trening
    builder.Train();
    return builder.GetResult();
}

var results = new List<WarriorPost>();

//Budujemy 2 piechurów
var piechurBuilder = new PiechurBuilder();
results.Add(BuildWarrior(piechurBuilder, "Piechur"));
results.Add(BuildWarrior(piechurBuilder, "Piechur"));

// Budujemy 2 strzelców
var strzelecBuilder = new StrzelecBuilder();
results.Add(BuildWarrior(strzelecBuilder, "Strzelec"));
results.Add(BuildWarrior(strzelecBuilder, "Strzelec"));

//Budujemy 2 konnych
var konnyBuilder = new KonnyBuilder();
results.Add(BuildWarrior(konnyBuilder, "Konny"));
results.Add(BuildWarrior(konnyBuilder, "Konny"));

//Wynik
Console.WriteLine("Wyszkoleni wojownicy:");
foreach (var w in results)
{
    Console.WriteLine(w);
}