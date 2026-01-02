using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Klasa systemu: wpuszcza tylko dorosłych i sprawdza wiek >= 18
//NightClub nie zna Teenager, zna Adult

public sealed class NightClub
{
    public bool CanEnter(Adult person)
    {
        return person.Age >= 18;
    }

    public void Enter(Adult person)
    {
        if (!CanEnter(person))
        {
            Console.WriteLine($"{person.Name} nie może wejść (wiek={person.Age})");
            return;
        }

        Console.WriteLine($"{person.Name} wchodzi do klubu (wiek={person.Age})");
    }
}
