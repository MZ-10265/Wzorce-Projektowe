using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public sealed class DiscountDecorator : Decorator
{
    public DiscountDecorator(Shop shop) : base(shop) { }

    public override void Buy(string product, decimal price)
    {
        decimal discounted = price * 0.9m;
        Console.WriteLine($"Rabat 10% → cena po rabacie: {discounted} PLN");
        base.Buy(product, discounted);
    }
}