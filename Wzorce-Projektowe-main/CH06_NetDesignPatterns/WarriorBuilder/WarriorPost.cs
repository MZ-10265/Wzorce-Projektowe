using WarriorFactory;

public class WarriorPost
{
    //Jakiego typu wojownik
    public string Type { get; set; } = "";

    //Czy został zapisany do służby
    public bool IsRegistered { get; set; }

    //Jaką dostał broń
    public string Weapon { get; set; } = "";

    //Jaki przeszedł trening
    public string Training { get; set; } = "";

    public override string ToString()
    {
        return $"{Type} | Registered={IsRegistered} | Weapon={Weapon} | Training={Training}";
    }
}
