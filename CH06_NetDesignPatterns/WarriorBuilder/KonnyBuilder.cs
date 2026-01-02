using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorFactory;

public sealed class KonnyBuilder : WarriorBuilder
{
    public override void Register()
    {
        _warrior.IsRegistered = true;
    }

    public override void GiveWeapon()
    {
        _warrior.Weapon = "Lanca";
    }

    public override void Train()
    {
        _warrior.Training = "Zaawansowany (konny)";
    }
}
