using System;

namespace Pattern___Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle = new Bike();

            Console.WriteLine("Go to bike trip");
            vehicle.Move();
            Console.WriteLine("We are tired");
            vehicle.Refuel();
            vehicle.Move();
            vehicle.Inspection();
            Console.WriteLine("Bike chain broke, we cant fix that");
            Console.WriteLine("Swipe bike for the car");

            vehicle = new Car();
            vehicle.Move();
            vehicle.Move();
            vehicle.Move();
            Console.WriteLine("Fuel is over, no gas stations nearby");
            Console.WriteLine("We only see a wild horse near us");
            Console.WriteLine("We trying to tame a horse");

            IMount horse = new Horse();
            MountAdapter mountAdapter = new MountAdapter(horse);
            vehicle = mountAdapter;

            vehicle.Move();
            vehicle.Move();
            vehicle.Move();
            vehicle.Move();

            Console.WriteLine("The horse is tired");
            vehicle.Refuel();
            Console.WriteLine("Go home");
            vehicle.Move();
            Console.WriteLine("Congrats, we are home");
            vehicle.Inspection();

            Console.ReadKey();
        }
    }
}