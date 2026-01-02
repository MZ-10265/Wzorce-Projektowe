
//dekorator (abstrakcyjny) dziedziczy po Shop ale wewnątrz trzyma iny obiekt Shop

public abstract class Decorator : Shop
{
    protected readonly Shop _shop;

    protected Decorator(Shop shop)
    {
        _shop = shop;
    }

    public override void Buy(string product, decimal price)
    {
        //przekazujemy wywołanie dalej (do dekorowanego obiektu)
        _shop.Buy(product, price);
    }
}