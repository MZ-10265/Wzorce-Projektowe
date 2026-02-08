using System;

namespace Solutions_MZ;

public static class Task15_PrimitiveObsession
{
    public sealed class ProductDetails
    {
        public string Name { get; }
        public string Category { get; }
        public decimal Price { get; }
        public int Quantity { get; }

        public ProductDetails(string name, string category, decimal price, int quantity)
        {
            Name = name;
            Category = category;
            Price = price;
            Quantity = quantity;
        }
    }

    public sealed class ProductManager
    {
        public void RegisterProduct(ProductDetails product)
        {
            Console.WriteLine($"Product: {product.Name}, Category: {product.Category}, Price: {product.Price}, Quantity: {product.Quantity}");
        }
    }

    public static void Run()
    {
        Console.WriteLine("[15] Primitive Obsession");

        var manager = new ProductManager();
        var product = new ProductDetails("Mouse", "Accessories", 99.99m, 5);

        manager.RegisterProduct(product);

        Console.WriteLine("Expected: one line with product details");
    }
}
