using System;

namespace CH01_CodeSmells_MZ.Solutions_MZ;

public static class Task01_LongParameterList
{
    //Parametr Object: ProductInfo grupuje dane produktu i dostawcy
    public sealed class ProductInfo
    {
        public string Name { get; }
        public string Category { get; }
        public decimal Price { get; }
        public int Stock { get; }
        public SupplierInfo Supplier { get; }

        public ProductInfo(string name, string category, decimal price, int stock, SupplierInfo supplier)
        {
            Name = name;
            Category = category;
            Price = price;
            Stock = stock;
            Supplier = supplier;
        }
    }

    public sealed class SupplierInfo
    {
        public string Name { get; }
        public string Contact { get; }

        public SupplierInfo(string name, string contact)
        {
            Name = name;
            Contact = contact;
        }
    }

    public sealed class ProductService
    {
        public void RegisterProduct(ProductInfo product)
        {
            Console.WriteLine(
                $"Product: {product.Name}, Category: {product.Category}, Price: {product.Price:C}, " +
                $"Stock: {product.Stock}, Supplier: {product.Supplier.Name}, Contact: {product.Supplier.Contact}"
            );
        }
    }

    // TEST
    public static void Run()
    {
        Console.WriteLine("[01] Long Parameter List");

        var service = new ProductService();
        var product = new ProductInfo(
            name: "Laptop",
            category: "Electronics",
            price: 4999.99m,
            stock: 10,
            supplier: new SupplierInfo("TechSupplier", "+48 500 600 700")
        );

        service.RegisterProduct(product);

        Console.WriteLine("Expected: one line with product + supplier details.");
    }
}
