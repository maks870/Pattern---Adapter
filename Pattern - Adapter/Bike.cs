using System;

class Bike : IVehicle
{
    public void Inspection()
    {
        Console.WriteLine("We check our bike");
        Console.WriteLine("Fixing problems");
    }

    public void Move()
    {
        Console.WriteLine("We travel by bike");
    }

    public void Refuel()
    {
        Console.WriteLine("We had a snack");
    }
}

