using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class SantaClausFactory
{
    public static Toy CreateToy(bool isGoodChild)
    {
        if (isGoodChild)
        {
            return new Gift();
        }

        return new Rod();
    }
}