namespace Garage;

public class Ram : Vehicle
{
    public double FuelCapacity { get; set; }
   
    public void RefuelTank()
    {
        Console.WriteLine($"This {Model}'s color is {MainColor}, and can hold {MaximumOccupancy} passengers.");
        Drive();
        Turn("right");
        Stop();
    }

    public override void Drive()
    {
        Console.WriteLine($"The {Model} sounds like Rump Rump Rupm when driving.");
    }

    public override void Turn(string direction)
    {
        Console.WriteLine($"The {Model} pickup truck carefully turns {direction}");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {Model} pickup truck rolls to an abrupt very hard stop.");
    }
}