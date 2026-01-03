using System;
using System.Globalization;

namespace Solutions_MZ;

public static class Task16_DataClass
{
    public sealed class Product
    {
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        //logika biznesowa w klasie
        public string GetFormattedPrice()
        {
            //bezpieczne formatowanie niezależne od systemu
            return Price.ToString("C", CultureInfo.CurrentCulture);
        }

        public bool IsInStock() => StockQuantity > 0;
    }

    public static void Run()
    {
        Console.WriteLine("[16] Data Class");

        var product = new Product { Name = "Keyboard", Price = 250.50m, StockQuantity = 3 };

        Console.WriteLine($"Name: {product.Name}");
        Console.WriteLine($"Formatted price: {product.GetFormattedPrice()}");
        Console.WriteLine($"In stock: {product.IsInStock()} (expected True)");
    }
}
