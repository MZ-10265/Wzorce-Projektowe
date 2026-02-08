

public class Shop
{
    public virtual void Buy(string product, decimal price)
    {
        Console.WriteLine($"🛒 Kupiono produkt: {product} za {price} PLN");
    }
}