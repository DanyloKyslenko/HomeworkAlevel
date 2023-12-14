using System.ComponentModel.DataAnnotations;
using ClassLibrary;
class Program
{
    public static void Main(string[] args)
    {
        Fleet fleet = new Fleet();

        Car car = new Car("Toyota Sedan", "Road", 150, 2);
        Car bike = new Car("Honda Cub", "Road", 60, 0.3);
        Bus bus = new Bus("Mercedes-Benz eCitaro", "Road", 200, 5);
        Airplane plane = new Airplane("Airbus A320neo", "Air", 840, 41.8);
        fleet.AddVehicle(car);
        fleet.AddVehicle(bike);
        fleet.AddVehicle(bus);
        fleet.AddVehicle(plane);

        List<VehicleBase> sortedByWeight = fleet.SortByWeight();
        Console.WriteLine("Sorted by weight:");
        foreach (VehicleBase vehicle in sortedByWeight)
        {
            Console.WriteLine($"{vehicle.Model} - {vehicle.Weight} ton");
        }
    }
}