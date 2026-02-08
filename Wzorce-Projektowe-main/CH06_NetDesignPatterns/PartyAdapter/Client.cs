using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//pokazuje różnicę: bez adaptera Teenager nie wejdzie, z adapterem wejdzie
public static class Client
{
    public static void Run()
    {
        var club = new NightClub();
        var teen = new Teenager("Krzysiek", 17);

        //bez adaptera nie możemy wywołać club.Enter(teen)
        Console.WriteLine("Bez adaptera Teenager nie pasuje do systemu (NightClub).");

        //tworze adapter: FakeAdult, który "udaje" Adult
        var fake = new FakeAdult(teen);

        Console.WriteLine($"Teenager real age: {teen.Age}");
        Console.WriteLine($"FakeAdult age: {fake.Age} (oszukane na potrzeby systemu)");

        //NightClub przyjmuje FakeAdultbo to jest Adult
        club.Enter(fake);
    }
}
