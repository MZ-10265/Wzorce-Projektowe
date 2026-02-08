using System;

namespace Solutions_MZ;

public static class Task14_LargeClass
{
    public sealed class OrderProcessor
    {
        public void ProcessOrders() => Console.WriteLine("Processing orders.");
    }

    public sealed class InventoryManager
    {
        public void ManageInventory() => Console.WriteLine("Managing inventory.");
    }

    public sealed class DeliveryCoordinator
    {
        public void CoordinateDeliveries() => Console.WriteLine("Coordinating deliveries.");
    }

    public sealed class ReturnHandler
    {
        public void HandleReturns() => Console.WriteLine("Handling returns.");
    }

    //WarehouseManager zostaje jako “orchestrator”
    public sealed class WarehouseManager
    {
        private readonly OrderProcessor _orders;
        private readonly InventoryManager _inventory;
        private readonly DeliveryCoordinator _deliveries;
        private readonly ReturnHandler _returns;

        public WarehouseManager(
            OrderProcessor orders,
            InventoryManager inventory,
            DeliveryCoordinator deliveries,
            ReturnHandler returns)
        {
            _orders = orders;
            _inventory = inventory;
            _deliveries = deliveries;
            _returns = returns;
        }

        public void RunDailyOperations()
        {
            _orders.ProcessOrders();
            _inventory.ManageInventory();
            _deliveries.CoordinateDeliveries();
            _returns.HandleReturns();
        }
    }

    public static void Run()
    {
        Console.WriteLine("[14] Large Class");

        var manager = new WarehouseManager(
            new OrderProcessor(),
            new InventoryManager(),
            new DeliveryCoordinator(),
            new ReturnHandler()
        );

        manager.RunDailyOperations();

        Console.WriteLine("Expected: orders -> inventory -> deliveries -> returns");
    }
}
