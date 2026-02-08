using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// FakeAdult dziedziczy po Adult (czyli jest Adult dla NightClub)
// wewnątrz trzyma Teenager, dzięki temu NightClub przyjmie FakeAdult jako Adult

public sealed class FakeAdult : Adult
{
    private readonly Teenager _teenager;

    public FakeAdult(Teenager teenager)
        // wywołujemy konstruktor Adult, ale "oszukujemy" wiek na 18
        : base(teenager.Name, 18)
    {
        _teenager = teenager;
    }

    //dowod
    public int RealAge => _teenager.Age;
}