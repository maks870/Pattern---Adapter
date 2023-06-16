using System;

class Horse : IMount
{
    public void Control()
    {
        Console.WriteLine("Ride a horse");
    }

    public void Feed()
    {
        Console.WriteLine("Feed a horse");
    }

    public void Rest()
    {
        Console.WriteLine("Let the horse rest");
    }

    public void VisitToDoctor()
    {
        Console.WriteLine("Take the horse to the vet");
    }
}
