using System;
namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of tires on the vehicle: ");
            VehicleFactory.GetVehicle(Console.ReadLine());
            
        }
    }
}
