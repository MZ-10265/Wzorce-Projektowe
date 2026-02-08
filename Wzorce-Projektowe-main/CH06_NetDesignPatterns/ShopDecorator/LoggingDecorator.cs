using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public sealed class LoggingDecorator : Decorator
{
    public LoggingDecorator(Shop shop) : base(shop) { }

    public override void Buy(string product, decimal price)
    {
        Console.WriteLine($"[LOG] Start zakupu: {product}");
        base.Buy(product, price);
        Console.WriteLine("[LOG] Koniec zakupu");
    }
}
