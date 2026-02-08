using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public sealed class Vault
{
    private static readonly Lazy<Vault> _instance = new(() => new Vault());

    public static Vault Instance => _instance.Value;

    //Cyfrowy klucz
    private readonly string _key;

    //Flaga
    private bool _issued;

    //Prywatny konstruktor uniemożliwia zrobienie "new Vault()" z zewnątrz
    private Vault()
    {
        _key = Guid.NewGuid().ToString("N"); 
        _issued = false;
    }

    //Zwraca true tylko ZA PIERWSZYM RAZEM.
    //Kolejne wywołania zwracają false.
    public bool TryGetKey(out string key)
    {
        if (_issued)
        {
            key = string.Empty;
            return false;
        }

        _issued = true;
        key = _key;
        return true;
    }
}
