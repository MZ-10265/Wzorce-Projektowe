
//Działa ale nie jest klasycznym dekoratorem, klient musi znać konkretną klasę

public sealed class DekoratorBezDziedziczenia
{
    private readonly Shop _shop;

    public DekoratorBezDziedziczenia(Shop shop)
    {
        _shop = shop;
    }

    public void Buy(string product, decimal price)
    {
        Console.WriteLine("Logowanie zakupu (bez dziedziczenia)");
        _shop.Buy(product, price);
    }
}