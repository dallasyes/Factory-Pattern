using System;
namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of tires on the vehicle: ");
            IVehicle vehicle = VehicleFactory.GetVehicle(Console.ReadLine());

            if (vehicle == null)
            {
                Console.WriteLine("No vehicle could be created");
            }
            else
            {
                vehicle.Drive();
            }
        }
    }
}
