using System;

namespace Solutions_MZ;

public static class Task22_ShotgunSurgery
{
    public sealed class Customer
    {
        public string Name { get; set; } = "";
    }

    public sealed class Order
    {
        public string OrderId { get; set; } = "";
    }

    public sealed class OrderService
    {
        public Order CreateOrderFor(Customer customer)
        {
            if (customer is null) throw new ArgumentNullException(nameof(customer));

            Console.WriteLine($"Order created for customer {customer.Name}.");

            return new Order { OrderId = Guid.NewGuid().ToString("N")[..8].ToUpper() };
        }

        public void SaveOrder(Order order)
        {
            if (order is null) throw new ArgumentNullException(nameof(order));
            Console.WriteLine($"Order {order.OrderId} saved.");
        }
    }

    public static void Run()
    {
        Console.WriteLine("[22] Shotgun Surgery");

        var service = new OrderService();
        var customer = new Customer { Name = "Mateusz" };

        var order = service.CreateOrderFor(customer);
        service.SaveOrder(order);

        Console.WriteLine("Expected: Order created... then Order <id> saved.");
    }
}
