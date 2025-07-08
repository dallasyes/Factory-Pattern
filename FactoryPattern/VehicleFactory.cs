namespace FactoryPattern;

public static class VehicleFactory
{
    public static IVehicle GetVehicle(string tires)
    {
        tires = (tires.ToLower());
        if (tires == "two" || tires == "2")
        {
            return new Motorcycle();
        }

        if (tires == "four" || tires == "4")
        {
            return new Car();
        }
        else return null;
    }
}