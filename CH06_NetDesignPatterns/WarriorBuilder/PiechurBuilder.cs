using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorFactory;

public sealed class PiechurBuilder : WarriorBuilder
{
    public override void Register()
    {
        // zapis
        _warrior.IsRegistered = true;
    }

    public override void GiveWeapon()
    {
        // broń
        _warrior.Weapon = "Włócznia";
    }

    public override void Train()
    {
        //trening
        _warrior.Training = "Podstawowy (piechur)";
    }
}
