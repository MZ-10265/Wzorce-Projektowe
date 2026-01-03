using System;

namespace CH01_CodeSmells_MZ.Solutions_MZ;

public static class Task03_MessageChains
{
    public sealed class Car
    {
        //car trzyma silnik żeby nie tworzyć go przy każdym wywołaniu
        private readonly Engine _engine = new Engine();

        //nowa metoda skracająca łańcuch
        public string GetCylinderSize()
        {
            return _engine.GetCylinder().GetSize();
        }
    }

    public sealed class Engine
    {
        public Cylinder GetCylinder() => new Cylinder();
    }

    public sealed class Cylinder
    {
        public string GetSize() => "2.0L";
    }

    // TEST
    public static void Run()
    {
        Console.WriteLine("[03] Message Chains");

        var car = new Car();
        var cylinderSize = car.GetCylinderSize();

        Console.WriteLine($"Cylinder size: {cylinderSize}");
        Console.WriteLine("Expected: Cylinder size: 2.0L");
    }
}
