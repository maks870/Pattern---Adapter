using System;

class Car : IVehicle
{
    public void Inspection()
    {
        Console.WriteLine("We check our car");
        Console.WriteLine("Fixing problems");
    }

    public void Move()
    {
        Console.WriteLine("We travel by car");
    }

    public void Refuel()
    {
        Console.WriteLine("We fiil our car");
    }
}

