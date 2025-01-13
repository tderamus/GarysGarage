
namespace Garage;

public class Cessna : Vehicle
{
    public double FuelCapacity { get; set; }
    
    public void RefuelTank()
    {
        Console.WriteLine($"This {Model}'s color is {MainColor}, fuel capacity is {FuelCapacity} and can hold {MaximumOccupancy} passengers.");
    }

    public override void Drive()
    {
        Console.WriteLine("Zoooooom!");
    }

    public override void Turn(string direction)
    {
        Console.WriteLine($"The {Model} plane carefully turns {direction}");
    }
}