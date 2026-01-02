using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Toy
{
    public string Name { get; protected set; }

    public abstract void Prepare();
}
