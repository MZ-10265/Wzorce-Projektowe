
Console.WriteLine("=== ZAKUP BEZ DEKORATORÓW ===");
Shop shop = new Shop();
shop.Buy("Laptop", 5000);

Console.WriteLine();
Console.WriteLine("=== ZAKUP Z DEKORATORAMI ===");


Shop decoratedShop =
    new LoggingDecorator(
        new DiscountDecorator(
            new Shop()
        )
    );

decoratedShop.Buy("Laptop", 5000);