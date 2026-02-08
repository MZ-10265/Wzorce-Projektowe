using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorFactory;

public sealed class StrzelecBuilder : WarriorBuilder
{
    public override void Register()
    {
        _warrior.IsRegistered = true;
    }

    public override void GiveWeapon()
    {
        _warrior.Weapon = "Łuk";
    }

    public override void Train()
    {
        _warrior.Training = "Średni (strzelec)";
    }
}