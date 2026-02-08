using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public sealed class Rod : Toy
{
    public Rod()
    {
        Name = "RÓZGA";
    }

    public override void Prepare()
    {
        Console.WriteLine("Przygotowywanie rózgi...");
    }
}
