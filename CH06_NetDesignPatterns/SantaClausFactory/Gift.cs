using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public sealed class Gift : Toy
{
    public Gift()
    {
        Name = "MIŚ";
    }

    public override void Prepare()
    {
        Console.WriteLine("Przygotowywanie prezentu...");
    }
}
