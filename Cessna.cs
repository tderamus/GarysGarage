
namespace Garage;

public class Cessna : Vehicle
{
    public double FuelCapacity { get; set; }
    
    public void RefuelTank()
    {
        Console.WriteLine($"This {Model}'s color is {MainColor}, fuel capacity is {FuelCapacity} and can hold {MaximumOccupancy} passengers.");
        Drive();
        Turn("right");
        Stop();
    }

    public override void Drive()
    {
        Console.WriteLine($" When this {Model} plane flies it sounds like.....Zoooooom!");
    }

    public override void Turn(string direction)
    {
        Console.WriteLine($"The {Model} plane carefully turns {direction}");
    }

    public override void Stop()
    {
        Console.WriteLine($"The white {Model} rolls to a stop after rolling a mile down the runway.");
    }
}