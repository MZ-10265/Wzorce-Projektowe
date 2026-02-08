using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public sealed class Elf
{
    public Toy PrepareToy(bool isGoodChild)
    {
        Toy toy = SantaClausFactory.CreateToy(isGoodChild);
        toy.Prepare();
        return toy;
    }
}