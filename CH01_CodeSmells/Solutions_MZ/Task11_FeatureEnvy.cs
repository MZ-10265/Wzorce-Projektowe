using System;

namespace Solutions_MZ;

public static class Task11_FeatureEnvy
{
    public sealed class ShippingDetails
    {
        public string ShippingMethod { get; set; } = "Standard";
        public string Destination { get; set; } = "PL";
        public decimal CalculateShippingCost(decimal orderAmount)
        {
            return ShippingMethod switch
            {
                "Air" => orderAmount * 0.20m,
                "Sea" => orderAmount * 0.10m,
                _ => orderAmount * 0.15m
            };
        }
    }

    public sealed class Order
    {
        public ShippingDetails ShippingDetails { get; set; } = new ShippingDetails();
        public decimal Amount { get; set; }
        public decimal GetTotalWithShipping()
        {
            var shipping = ShippingDetails.CalculateShippingCost(Amount);
            return Amount + shipping;
        }
    }

    public static void Run()
    {
        Console.WriteLine("[11] Feature Envy");

        var order = new Order
        {
            Amount = 1000m,
            ShippingDetails = new ShippingDetails { ShippingMethod = "Air", Destination = "DE" }
        };

        var total = order.GetTotalWithShipping();
        Console.WriteLine($"Total with shipping: {total}");
        Console.WriteLine("Expected: 1000 + 20% = 1200");
    }
}
